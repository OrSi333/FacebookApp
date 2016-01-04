using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    class FBSpecialFeatures
    {
        private const string k_NameColumnHeader = "Name";
        private const string k_SharedEventsColumnHeader = "Number Of Shared Events";
        private const string k_SharedPhotosColumnHeader = "Number Of Shared Photos";
        private const string k_PhotosGridTag = "Photos";
        private const string k_EventsGridTag = "Events";
        private const int k_NumberOfEventsToFetch = 25;
        private const int k_NumberOfUsersFromEventsToFetch = 1000;
        private const int k_NumberOfPhotosToFetch = 500;
        private const int k_DefaultNumberOfObjectsToFetch = 25;
        private const int k_MinimunNumberOfSharedEventsToShow = 3;

        internal static List<UserRank<Event>> FetchAttendeesFromEvents(User i_LoggedInUser)
        {
            FacebookService.s_CollectionLimit = k_NumberOfEventsToFetch;
            FacebookObjectCollection<Event> userFacebookEvents = i_LoggedInUser.Events;
            Dictionary<string, UserRank<Event>> allAttendingUsersOnUserEvents = new Dictionary<string, UserRank<Event>>();
            FacebookService.s_CollectionLimit = k_NumberOfUsersFromEventsToFetch;
            ArrayList threadList = new ArrayList();
            foreach (Event userFacebookEvent in userFacebookEvents)
            {
                if (userFacebookEvent.Privacy == Event.ePrivacy.Open)
                {
                    Thread getAttendeesInEventThread = new Thread(() => getAttendeesInEvent(userFacebookEvent, allAttendingUsersOnUserEvents));
                    threadList.Add(getAttendeesInEventThread);
                }
            }
            
            foreach (Thread thread in threadList)
            {
                thread.Start();
            }

            foreach (Thread thread in threadList)
            {
                thread.Join();
            }

            List<string> usersToRemove = new List<string>();
            foreach (string userToCheck in allAttendingUsersOnUserEvents.Keys)
            {
                UserRank<Event> userRankToCheck;
                if (allAttendingUsersOnUserEvents.TryGetValue(userToCheck, out userRankToCheck))
                {
                    if (userRankToCheck.GetObjectCount() < k_MinimunNumberOfSharedEventsToShow || userToCheck == i_LoggedInUser.Id)
                    {
                        usersToRemove.Add(userToCheck);
                    }
                }
            }

            foreach (string userToRemove in usersToRemove)
            {
                allAttendingUsersOnUserEvents.Remove(userToRemove);
            }

            FacebookService.s_CollectionLimit = k_DefaultNumberOfObjectsToFetch;

            List<UserRank<Event>> allAttendingList = allAttendingUsersOnUserEvents.Values.ToList();

            return allAttendingList;
        }

        private static void getAttendeesInEvent(Event i_UserFacebookEvent, Dictionary<string, UserRank<Event>> i_AllAttendingUsersOnUserEvents)
        {
            foreach (User attendingUser in i_UserFacebookEvent.AttendingUsers)
            {
                UserRank<Event> currentAttendee;

                lock (i_AllAttendingUsersOnUserEvents)
                {
                     if (!i_AllAttendingUsersOnUserEvents.TryGetValue(attendingUser.Id, out currentAttendee))
                {
                    currentAttendee = new UserRank<Event>(attendingUser);
                    i_AllAttendingUsersOnUserEvents.Add(attendingUser.Id, currentAttendee);
                }

                currentAttendee.AddObjectToUser(i_UserFacebookEvent);
                }
            }
        }

        internal static List<UserRank<Photo>> FetchTags(User i_LoggedInUser)
        {
            FacebookService.s_CollectionLimit = k_NumberOfPhotosToFetch;
            FacebookObjectCollection<Photo> userTaggedPhotos = i_LoggedInUser.PhotosTaggedIn;
            Dictionary<string, UserRank<Photo>> allTaggedFriendsOnUserPhotos = new Dictionary<string, UserRank<Photo>>();
            foreach (Photo photo in userTaggedPhotos)
            {
                foreach (PhotoTag photoTag in photo.Tags)
                {
                    UserRank<Photo> currentFriendTag;
                    if (!allTaggedFriendsOnUserPhotos.TryGetValue(photoTag.User.Id, out currentFriendTag))
                    {
                        currentFriendTag = new UserRank<Photo>(photoTag.User);
                        allTaggedFriendsOnUserPhotos.Add(photoTag.User.Id, currentFriendTag);
                    }

                    currentFriendTag.AddObjectToUser(photo);
                }
            }

            allTaggedFriendsOnUserPhotos.Remove(i_LoggedInUser.Id);

            FacebookService.s_CollectionLimit = k_DefaultNumberOfObjectsToFetch;

            List<UserRank<Photo>> allTaggedAsList = allTaggedFriendsOnUserPhotos.Values.ToList();

            return allTaggedAsList;
        }

        internal static void FetchTags(User i_LoggedInUser, ListBox i_ListBoxFriendsWithRank)
        {
            List<UserRank<Photo>> allUsersWithTagsOnPhotos = CentralSingleton.Instance.SharedPhotosTagsListAdapter.UserRankList;
            if (allUsersWithTagsOnPhotos == null)
            {
                allUsersWithTagsOnPhotos = FetchTags(i_LoggedInUser);
                CentralSingleton.Instance.SharedPhotosTagsListAdapter.UserRankList = allUsersWithTagsOnPhotos;
            }

            ArrayList userRankList = new ArrayList(allUsersWithTagsOnPhotos);
            userRankList.Sort();
            userRankList.Reverse();
            foreach (UserRank<Photo> userRank in userRankList)
            {
                i_ListBoxFriendsWithRank.Invoke(new Action(() => i_ListBoxFriendsWithRank.Items.Add(userRank)));
            }
        }

        internal static void FetchAttendees(User i_LoggedInUser, ListBox i_ListBoxFriendsWithRank)
        {
            List<UserRank<Event>> allUsersWithSharedEvents = CentralSingleton.Instance.AttendeesFromEventListAdapter.UserRankList;
            if (allUsersWithSharedEvents == null)
            {
                allUsersWithSharedEvents = FetchAttendeesFromEvents(i_LoggedInUser);
                CentralSingleton.Instance.AttendeesFromEventListAdapter.UserRankList = allUsersWithSharedEvents;
            }

            ArrayList userRankList = new ArrayList(allUsersWithSharedEvents);
            userRankList.Sort();
            userRankList.Reverse();
            foreach (UserRank<Event> userRank in userRankList)
            {
                i_ListBoxFriendsWithRank.Invoke(new Action(() => i_ListBoxFriendsWithRank.Items.Add(userRank)));
            }
        }
    }
}
