using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    public partial class EventForm : Form
    {
        Event m_Event;
        
        public EventForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
        }

        public void LoadEvent(Event i_Event, Point i_LoadingLocation)
        {
            m_Event = i_Event;
            pictureBoxEventPhoto.LoadAsync(i_Event.PictureNormalURL);
            labelEventName.Text = i_Event.Name;
            labelEventDate.Text = i_Event.TimeString;
            labelHostName.Text = i_Event.Owner.Name;
            Point showLocation = new Point(i_LoadingLocation.X - 2 * Size.Width, i_LoadingLocation.Y);
            Location = showLocation;
        }

        private void buttonGoing_Click(object sender, EventArgs e)
        {
            m_Event.Respond(Event.eRsvpType.Attending);
            this.Close();
        }

        private void buttonMaybe_Click(object sender, EventArgs e)
        {
            m_Event.Respond(Event.eRsvpType.Maybe);
            this.Close();
        }

        private void buttonCantGo_Click(object sender, EventArgs e)
        {
            m_Event.Respond(Event.eRsvpType.Declined);
            this.Close();
        }
    }
}