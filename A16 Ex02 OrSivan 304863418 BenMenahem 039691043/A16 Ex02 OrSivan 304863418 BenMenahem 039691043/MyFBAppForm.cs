using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private EventForm m_selectedEventForm = null;
        private FBAppConfig m_appConfig;

        private Post CurrentPost { get; set; }

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
            fetchUserInfo();
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
                postedStatus = m_LoggedInUser.PostStatus(TextBoxStatus.Text, null);
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

            userBindingSource.DataSource = m_LoggedInUser;
            if (ueEv.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
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

                m_selectedEventForm = new EventForm();
                m_selectedEventForm.loadEvent(selectedEvent, ListBoxUndecidedEvents.PointToScreen(ListBoxUndecidedEvents.Location));
                m_selectedEventForm.Show();
                m_selectedEventForm.FormClosed += resetEventWindow;
            }
        }

        private void resetEventWindow(object sender, FormClosedEventArgs e)
        {
            m_selectedEventForm = null;
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
                if (CurrentPost != null)
                {
                    CurrentPost.Comment(TextBoxWallWriteComment.Text);
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
    }
}