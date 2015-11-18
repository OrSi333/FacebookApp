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
    public partial class Form1 : Form
    {
        private const string m_AppId = "1687163321527087";

        // Fields regarding status
        private const string m_StatusDefaultMessage = "What's on your mind?";

        // User
        User m_LoggedInUser;
        
        // Fields regarding event window
        private EventForm m_selectedEventForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
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
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
                doAfterLogin();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureSqaureURL);
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            Status postedStatus = null;
            try
            {
                postedStatus = m_LoggedInUser.PostStatus(textBoxStatus.Text, null, "c:/arik.jpg");
            }
            catch (FacebookOAuthException i_FBException)
            {
                MessageBox.Show(string.Format("Error: {0}", i_FBException.Message));
                return;
            }
            
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            textBoxStatus.Text = m_StatusDefaultMessage;
        }

        private void doAfterLogin()
        {
            tabControlFBFeatures.Enabled = true;
            
            FacebookObjectCollection<Event> ueEv = m_LoggedInUser.EventsNotYetReplied;
            listBoxUndecidedEvents.DisplayMember = "Name";
            foreach(Event currentEvent in ueEv)
            {
                listBoxUndecidedEvents.Items.Add(currentEvent);
            }

            if (ueEv.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void m_ShowTags_Click(object sender, EventArgs e)
        {
            FBSpecialFeatures.ShowTags_Click(sender, e, m_LoggedInUser, dataGridViewFriends);
        }

        private void dataGridViewFriends_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FBSpecialFeatures.dataGridViewFriends_CellDoubleClick(sender, e);
        }

        private void listBoxUndecidedEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUndecidedEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxUndecidedEvents.SelectedItem as Event;
                if (m_selectedEventForm != null)
                {
                    m_selectedEventForm.Close();
                }

                m_selectedEventForm = new EventForm();
                m_selectedEventForm.loadEvent(selectedEvent, listBoxUndecidedEvents.PointToScreen(listBoxUndecidedEvents.Location));
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
            FBSpecialFeatures.FetchEventFriends_Click(sender, e, m_LoggedInUser, dataGridViewFriends);
        }
    }
}
