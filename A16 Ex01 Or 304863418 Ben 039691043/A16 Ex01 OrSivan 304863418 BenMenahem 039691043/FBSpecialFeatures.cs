using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Windows.Forms;
using System.ComponentModel;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    class FBSpecialFeatures
    {
        internal class UserRank<T> {
            public User User { get; private set; }

            public string Id { get; private set; }
            
            public string Name { get; private set; }

            private List<T> m_ObjectsIn;

            public UserRank(User i_User) {
                User = i_User;
                Id = i_User.Id;
                Name = i_User.Name;
                m_ObjectsIn = new List<T>();
            }

            public void AddObjectToUser(T i_ObjectToAdd) {
                if (m_ObjectsIn.IndexOf(i_ObjectToAdd) == -1)
                {
                    m_ObjectsIn.Add(i_ObjectToAdd);
                }
            }

            public int GetObjectCount()
            {
                return m_ObjectsIn.Count;
            }

            public List<T> GetObjectList()
            {
                return m_ObjectsIn;
            }
        }

        internal static Dictionary<string, UserRank<Event>> FetchEvents(User i_LoggedInUser)
        {
            FacebookService.s_CollectionLimit = 25;
            FacebookObjectCollection<Event> userFacebookEvents = i_LoggedInUser.Events;
            Dictionary<string, UserRank<Event>> allAttendingUsersOnUserEvents = new Dictionary<string, UserRank<Event>>();
            FacebookService.s_CollectionLimit = 1000;
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
                    if (userRankToCheck.GetObjectCount() < 3 || userToCheck == i_LoggedInUser.Id)
                    {
                        usersToRemove.Add(userToCheck);
                    }
                }
            }

            foreach (string userToRemove in usersToRemove)
            {
                allAttendingUsersOnUserEvents.Remove(userToRemove);
            }
            
            return allAttendingUsersOnUserEvents;
        }

        internal static Dictionary<string, UserRank<Photo>> FetchTags(User i_LoggedInUser)
        {
            FacebookService.s_CollectionLimit = 500;
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

            return allTaggedFriendsOnUserPhotos;
        }

        internal static void dataGridViewFriends_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridView senderDataGridView = (DataGridView)sender;
                if (senderDataGridView.Tag.Equals("Photos"))
                {
                    FBSpecialFeatures.UserRank<Photo> userInfo = (FBSpecialFeatures.UserRank<Photo>)senderDataGridView.Rows[e.RowIndex].Cells[2].Value;
                    ImagesForm userSharedTaggedImagesForm = new ImagesForm();
                    userSharedTaggedImagesForm.Text = userInfo.Name + " Shared Photos";
                    foreach (Photo photo in userInfo.GetObjectList())
                    {
                        userSharedTaggedImagesForm.AddImageToGrid(photo);
                    }

                    userSharedTaggedImagesForm.Show();
                }
                else
                {
                    FBSpecialFeatures.UserRank<Event> userInfo = (FBSpecialFeatures.UserRank<Event>)senderDataGridView.Rows[e.RowIndex].Cells[2].Value;
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
            i_dataGridViewFriends.Tag = "Photos";
            i_dataGridViewFriends.Columns[0].HeaderText = "Name";
            i_dataGridViewFriends.Columns[1].HeaderText = "Shared Photos";
            i_dataGridViewFriends.Columns[2].Visible = false;

            Dictionary<string, FBSpecialFeatures.UserRank<Photo>> allUsersWithTagsOnPhotos = FBSpecialFeatures.FetchTags(i_LoggedInUser);
            foreach (FBSpecialFeatures.UserRank<Photo> userDetails in allUsersWithTagsOnPhotos.Values)
            {
                int index = i_dataGridViewFriends.Rows.Add(userDetails.Name, userDetails.GetObjectCount(), userDetails);
                i_dataGridViewFriends.Rows[index].ReadOnly = true;
            }

            i_dataGridViewFriends.Sort(i_dataGridViewFriends.Columns[1], ListSortDirection.Descending);
        }

        internal static void FetchEventFriends_Click(object sender, EventArgs e, User i_LoggedInUser, DataGridView i_dataGridViewFriends)
        {
            i_dataGridViewFriends.Rows.Clear();
            i_dataGridViewFriends.Tag = "Events";
            i_dataGridViewFriends.Columns[0].HeaderText = "Name";
            i_dataGridViewFriends.Columns[1].HeaderText = "Shared Events";
            i_dataGridViewFriends.Columns[2].Visible = false;

            Dictionary<string, FBSpecialFeatures.UserRank<Event>> allUsersWithSharedEvents = FBSpecialFeatures.FetchEvents(i_LoggedInUser);
            foreach (FBSpecialFeatures.UserRank<Event> userDetails in allUsersWithSharedEvents.Values)
            {
                int index = i_dataGridViewFriends.Rows.Add(userDetails.Name, userDetails.GetObjectCount(), userDetails);
                i_dataGridViewFriends.Rows[index].ReadOnly = true;
            }

            i_dataGridViewFriends.Sort(i_dataGridViewFriends.Columns[1], ListSortDirection.Descending);
        }
    }
}
