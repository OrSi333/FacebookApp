﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    public partial class MyFBAppForm : Form
    {
        private const string m_AppId = "1687163321527087";
        private const string k_likeButtonLabel = "Like";
        private const string k_unlikeButtonLabel = "Unlike";
        private const string m_StatusDefaultMessage = "What's on your mind?";
        

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

        private User m_LoggedInUser;
        private IEventFormFacade m_selectedEventForm = EventFormFacade.CreateForm();
        private FBAppConfig m_appConfig;

        public MyFBAppForm()
        {
            InitializeComponent();
            m_appConfig = CentralSingleton.Instance.AppConfig;
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string accessToken = m_appConfig.LastAccessToken;
            if (string.IsNullOrEmpty(accessToken))
            {
                loginAndInit();
            }
            else
            {
                loginFromAccessToken(accessToken);
            }
        }

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login(
                m_AppId,
                "public_profile",
                "user_education_history",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.fitness",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_games_activity",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",
                "read_page_mailboxes",
                "manage_pages",
                "publish_pages",
                "publish_actions",
                "rsvp_event");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_appConfig.LastAccessToken = result.AccessToken;
                initApp(result);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void loginFromAccessToken(string i_AccessToken)
        {
            try
            {
                LoginResult results = FacebookService.Connect(i_AccessToken);
                initApp(results);
            }
            catch (FacebookOAuthException FBOAuthException)
            {
                loginAndInit();
            }
        }

        private void initApp(LoginResult i_Results)
        {
            m_LoggedInUser = i_Results.LoggedInUser;
            new Thread(() => fetchUserInfo()).Start();
            doAfterLogin();
        }

        private void fetchUserInfo()
        {
            PictureBoxProfile.LoadAsync(m_LoggedInUser.PictureSqaureURL);
            fetchWallPosts();
        }

        private void fetchWallPosts()
        {
            postBindingSource.DataSource = m_LoggedInUser.Posts;
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            Status postedStatus = null;
            try
            {
                string statusToPost = TextBoxStatus.Text;
                new Thread(() => postedStatus = m_LoggedInUser.PostStatus(statusToPost, null)).Start();
            }
            catch (FacebookOAuthException i_FBException)
            {
                MessageBox.Show(string.Format("Error: {0}", i_FBException.Message));
                return;
            }
            
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            TextBoxStatus.Text = m_StatusDefaultMessage;
        }

        private void doAfterLogin()
        {
            tabControlFBFeatures.Enabled = true;
            
            FacebookObjectCollection<Event> ueEv = m_LoggedInUser.EventsNotYetReplied;
            
            ListBoxUndecidedEvents.DisplayMember = "Name";
            foreach(Event currentEvent in ueEv)
            {
                ListBoxUndecidedEvents.Items.Add(currentEvent);
            }

            if (ueEv.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }

            this.ApplyFiltersButton.Click += (i_Sender, i_EventArgs) =>
            {
                RemoveFiltersButton.Enabled = true;
                ApplyFiltersButton.Enabled = false;
            };
            this.RemoveFiltersButton.Click += (i_Sender, i_EventArgs) =>
            {
                RemoveFiltersButton.Enabled = false;
                ApplyFiltersButton.Enabled = true;
            };
        }

        private void m_ShowTags_Click(object sender, EventArgs e)
        {
            listBoxFriendsWithRank.Tag = k_PhotosGridTag;
            listBoxFriendsWithRank.Items.Clear();
            new Thread(createPhotosFriendsListBox).Start();
        }

        private void createPhotosFriendsListBox()
        {
            FBSpecialFeatures.FetchTags(m_LoggedInUser, listBoxFriendsWithRank);
        }

        private void listBoxUndecidedEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxUndecidedEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = ListBoxUndecidedEvents.SelectedItem as Event;
                if (m_selectedEventForm != null)
                {
                    m_selectedEventForm.Close();
                }
                else
                {
                    m_selectedEventForm = EventFormFacade.CreateForm();
                }

                m_selectedEventForm.LoadAndShowEvent(selectedEvent, ListBoxUndecidedEvents.PointToScreen(ListBoxUndecidedEvents.Location));
                textBoxNameForBlacklist.Text = selectedEvent.Owner.Name;
            }
        }

        private void m_FetchEventFriends_Click(object sender, EventArgs e)
        {
            listBoxFriendsWithRank.Tag = k_EventsGridTag;
            listBoxFriendsWithRank.Items.Clear();

            new Thread(createEventFriendsListBox).Start();
        }

        private void createEventFriendsListBox()
        {
            FBSpecialFeatures.FetchAttendees(m_LoggedInUser, listBoxFriendsWithRank);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {   
                if (ListBoxWallPosts.SelectedItem != null)
                {
                    Post currentPost = ListBoxWallPosts.SelectedItem as Post;
                    string statusToWrite = TextBoxWallWriteComment.Text;
                    new Thread(() => currentPost.Comment(statusToWrite)).Start();
                }
                else
                {
                    MessageBox.Show("No post was selected!");
                }
            }
            catch (FacebookOAuthException i_FBOAuthException)
            {
                MessageBox.Show(i_FBOAuthException.Message);
            }
            catch (NullReferenceException i_nullReferenceException)
            {
                MessageBox.Show(i_nullReferenceException.Message);
            }

            MessageBox.Show("Posted!");
        }

        private void listBoxFriendsWithRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox senderListBox = (ListBox)sender;
            m_PanelPeopleInSameEvents.Visible = false;
            m_PanelSharedImagesWithFriend.Visible = false;
            if (senderListBox.Tag.Equals(k_PhotosGridTag))
            {
                UserRank<Photo> userInfo = (UserRank<Photo>)senderListBox.SelectedItem;
                m_FlowLayoutPanelSharedImages.Controls.Clear();
                m_PanelSharedImagesWithFriend.Visible = true;
                foreach (Photo photo in userInfo.GetObjectList())
                {
                    PictureBox currentPhotoBox = new PictureBox();
                    currentPhotoBox.Image = photo.ImageThumb;
                    currentPhotoBox.Name = photo.PictureNormalURL;

                    currentPhotoBox.Click += new System.EventHandler(pictureBox_Click);
                    m_FlowLayoutPanelSharedImages.Controls.Add(currentPhotoBox);
                    m_FlowLayoutPanelSharedImages.Visible = true;
                }
            }
            else
            {
                UserRank<Event> userInfo = (UserRank<Event>)senderListBox.SelectedItem;
                m_PanelPeopleInSameEvents.Visible = true;
                m_PictureBoxUserFromSharedEvents.Image = userInfo.ImageSquare;
                m_ListBoxSharedEvents.DisplayMember = "Name";
                m_ListBoxSharedEvents.Items.Clear();
                foreach (Event sharedEvent in userInfo.GetObjectList())
                {
                    m_ListBoxSharedEvents.Items.Add(sharedEvent);
                }
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox senderPictureBox = (PictureBox)sender;
            string url = senderPictureBox.Name;
            ImagesForm bigPictureForm = new ImagesForm();
            bigPictureForm.SingleImageToShow(url);
            bigPictureForm.Text = string.Empty;
            bigPictureForm.Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            m_appConfig.SaveToXml();
            base.OnClosing(e);
        }

        private void ApplyFiltersButton_Click_1(object sender, EventArgs e)
        {
            if (m_selectedEventForm != null)
            {
                m_selectedEventForm.Close();
            }

            FacebookObjectCollection<Event> unRepliedEvents = m_LoggedInUser.EventsNotYetReplied;
            FacebookObjectCollection<Event> filteredUnRepliedEvents = new FacebookObjectCollection<Event>();
            foreach (Event currentEvent in unRepliedEvents)
            {
                filteredUnRepliedEvents.Add(currentEvent);
            }

            foreach (Event currentEvent in unRepliedEvents)
            {
                foreach (string name in m_appConfig.EventHostBlacklist)
                {
                    if (currentEvent.Owner.Name == name)
                    {
                        filteredUnRepliedEvents.Remove(currentEvent);
                    }
                }
            }
            ListBoxUndecidedEvents.Items.Clear();
            foreach (Event currentEvent in filteredUnRepliedEvents)
            {
                ListBoxUndecidedEvents.Items.Add(currentEvent);
            }

            m_selectedEventForm = m_selectedEventForm
                .Decorate((i_Event) => 
                    MessageBox.Show(string.Format("Hosted by: {0}", i_Event.Owner.Name)),
                    (i_Event) =>
                    {
                        DialogResult dialogResult = MessageBox.Show(string.Format("Do you want to add {0} to blacklist?",i_Event.Owner.Name), string.Empty, MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            addNameToBlacklist(i_Event.Owner.Name);
                        }

                    })
                .Decorate((i_Event, i_EventOwnerBlackList) => !i_EventOwnerBlackList.Contains(i_Event.Owner.Name),
                    m_appConfig.EventHostBlacklist,
                    (i_Event) =>
                        MessageBox.Show(string.Format("You are not allowed to see events hosted by {0}",
                            i_Event.Owner.Name)));

        }

        private void RemoveFiltersButton_Click_1(object sender, EventArgs e)
        {
            m_selectedEventForm.Close();
            m_selectedEventForm = null;
            FacebookObjectCollection<Event> unRepliedEvents = m_LoggedInUser.EventsNotYetReplied;
            ListBoxUndecidedEvents.Items.Clear();
            foreach (Event currentEvent in unRepliedEvents)
            {
                ListBoxUndecidedEvents.Items.Add(currentEvent);
            }

        }

        private void buttonAddToBlacklist_Click(object sender, EventArgs e)
        {
            addNameToBlacklist(textBoxNameForBlacklist.Text);
        }

        private void addNameToBlacklist(string nameFromTextbox)
        {
            if (!string.IsNullOrEmpty(nameFromTextbox))
            {
                if (!m_appConfig.EventHostBlacklist.Contains(nameFromTextbox))
                {
                    m_appConfig.EventHostBlacklist.Add(nameFromTextbox);
                    EventHostBlacklistBox.Items.Add(nameFromTextbox);
                    MessageBox.Show(string.Format("{0} was added to the blacklist", nameFromTextbox));
                }
                else
                {
                    MessageBox.Show(string.Format("{0} is alredy in the blacklist!", nameFromTextbox));
                }
                textBoxNameForBlacklist.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Can't add a blank name to blacklist!");
            }
        }

        private void EventHostBlacklistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EventHostBlacklistBox.Items.Count != 0)
            {
                textBoxNameForBlacklist.Text = (string)EventHostBlacklistBox.SelectedItem;
            }
            else
            {
                textBoxNameForBlacklist.Text = string.Empty;
            }
        }

        private void buttonRemoveFromBlacklist_Click(object sender, EventArgs e)
        {

            EventHostBlacklistBox.Items.Remove(EventHostBlacklistBox.SelectedItem);
        }

    }
}