﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    public partial class ImagesForm : Form
    {
        public ImagesForm()
        {
            InitializeComponent();
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
    }
}
