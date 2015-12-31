using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    public partial class UserSharedEventsForm : Form
    {
        public UserSharedEventsForm()
        {
            InitializeComponent();
        }

        internal void SetUserDetails(UserRank<Event> i_userRank)
        {
            userThumbnail.Image = i_userRank.User.ImageNormal;
            foreach (Event sharedEvent in i_userRank.GetObjectList())
            {
                userSharedEventsListBox.Items.Add(sharedEvent.Name);
            }
        }
    }
}
