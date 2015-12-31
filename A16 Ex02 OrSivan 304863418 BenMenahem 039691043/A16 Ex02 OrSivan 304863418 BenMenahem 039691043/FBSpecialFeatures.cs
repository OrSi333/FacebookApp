using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
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

        internal static Dictionary<string, UserRank<Event>> FetchAttendeesFromEvents(User i_LoggedInUser)
        {
            FacebookService.s_CollectionLimit = k_NumberOfEventsToFetch;
            FacebookObjectCollection<Event> userFacebookEvents = i_LoggedInUser.Events;
            Dictionary<string, UserRank<Event>> allAttendingUsersOnUserEvents = new Dictionary<string, UserRank<Event>>();
            FacebookService.s_CollectionLimit = k_NumberOfUsersFromEventsToFetch;
            foreach (Event userFacebookEvent in userFacebookEvents)
            {
                if (userFacebookEvent.Privacy == Event.ePrivacy.Open)
                {
                    foreach (User attendingUser in userFacebookEvent.AttendingUsers)
                    {
                        UserRank<Event> currentAttendee;

                        if (!allAttendingUsersOnUserEvents.TryGetValue(attendingUser.Id, out currentAttendee))
                        {
                            currentAttendee = new UserRank<Event>(attendingUser);
                            allAttendingUsersOnUserEvents.Add(attendingUser.Id, currentAttendee);
                        }

                        currentAttendee.AddObjectToUser(userFacebookEvent);
                    }
                }
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
            
            return allAttendingUsersOnUserEvents;
        }

        internal static Dictionary<string, UserRank<Photo>> FetchTags(User i_LoggedInUser)
        {
            FacebookService.s_CollectionLimit = k_NumberOfPhotosToFetch;
            FacebookObjectCollection<Photo> userTaggedPhotos = i_LoggedInUser.PhotosTaggedIn;
            Dictionary<string, UserRank<Photo>> allTaggedFriendsOnUserPhotos = new Dictionary<string, UserRank<Photo>>();
            foreach (Photo photo in userTaggedPhotos)
            {
                foreach (PhotoTag photoTag in photo.Tags) {
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

            return allTaggedFriendsOnUserPhotos;
        }

        internal static void dataGridViewFriends_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridView senderDataGridView = (DataGridView)sender;
                if (senderDataGridView.Tag.Equals(k_PhotosGridTag))
                {
                    UserRank<Photo> userInfo = (UserRank<Photo>)senderDataGridView.Rows[e.RowIndex].Cells[2].Value;
                    ImagesForm userSharedTaggedImagesForm = new ImagesForm();
                    userSharedTaggedImagesForm.Text = string.Format("{0} Shared Photos", userInfo.Name);
                    foreach (Photo photo in userInfo.GetObjectList())
                    {
                        userSharedTaggedImagesForm.AddImageToGrid(photo);
                    }

                    userSharedTaggedImagesForm.Show();
                }
                else
                {
                    UserRank<Event> userInfo = (UserRank<Event>)senderDataGridView.Rows[e.RowIndex].Cells[2].Value;
                    UserSharedEventsForm userSharedEventsForm = new UserSharedEventsForm();
                    userSharedEventsForm.Text = userInfo.Name;
                    userSharedEventsForm.SetUserDetails(userInfo);
                    userSharedEventsForm.Show();
                }
            }
        }

        internal static void ShowTags_Click(object sender, EventArgs e, User i_LoggedInUser, DataGridView i_dataGridViewFriends)
        {
            i_dataGridViewFriends.Rows.Clear();
            i_dataGridViewFriends.Tag = k_PhotosGridTag;
            i_dataGridViewFriends.Columns[0].HeaderText = k_NameColumnHeader;
            i_dataGridViewFriends.Columns[1].HeaderText = k_SharedPhotosColumnHeader;
            i_dataGridViewFriends.Columns[2].Visible = false;

            Dictionary<string, UserRank<Photo>> allUsersWithTagsOnPhotos = FetchTags(i_LoggedInUser);
            foreach (UserRank<Photo> userDetails in allUsersWithTagsOnPhotos.Values)
            {
                int index = i_dataGridViewFriends.Rows.Add(userDetails.Name, userDetails.GetObjectCount(), userDetails);
                i_dataGridViewFriends.Rows[index].ReadOnly = true;
            }

            i_dataGridViewFriends.Sort(i_dataGridViewFriends.Columns[1], ListSortDirection.Descending);
        }

        internal static void FetchEventFriends_Click(object sender, EventArgs e, User i_LoggedInUser, DataGridView i_dataGridViewFriends)
        {
            i_dataGridViewFriends.Rows.Clear();
            i_dataGridViewFriends.Tag = k_EventsGridTag;
            i_dataGridViewFriends.Columns[0].HeaderText = k_NameColumnHeader;
            i_dataGridViewFriends.Columns[1].HeaderText = k_SharedEventsColumnHeader;
            i_dataGridViewFriends.Columns[2].Visible = false;

            Dictionary<string, UserRank<Event>> allUsersWithSharedEvents = FetchAttendeesFromEvents(i_LoggedInUser);
            foreach (UserRank<Event> userDetails in allUsersWithSharedEvents.Values)
            {
                int index = i_dataGridViewFriends.Rows.Add(userDetails.Name, userDetails.GetObjectCount(), userDetails);
                i_dataGridViewFriends.Rows[index].ReadOnly = true;
            }

            i_dataGridViewFriends.Sort(i_dataGridViewFriends.Columns[1], ListSortDirection.Descending);
        }
    }
}
