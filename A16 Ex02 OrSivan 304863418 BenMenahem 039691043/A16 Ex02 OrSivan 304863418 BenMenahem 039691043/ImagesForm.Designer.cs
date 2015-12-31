using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    partial class ImagesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // imagesFlowLayoutPanel
            // 
            this.imagesFlowLayoutPanel.AutoScroll = true;
            this.imagesFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagesFlowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.imagesFlowLayoutPanel.Name = "imagesFlowLayoutPanel";
            this.imagesFlowLayoutPanel.Size = new System.Drawing.Size(746, 522);
            this.imagesFlowLayoutPanel.TabIndex = 1;
            // 
            // ImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 546);
            this.Controls.Add(this.imagesFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ImagesForm";
            this.Text = "ImagesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel imagesFlowLayoutPanel;

        public void AddImageToGrid(Photo i_PhotoToAdd)
        {
            PictureBox currentPhotoBox = new PictureBox();
            currentPhotoBox.Image = i_PhotoToAdd.ImageThumb;
            currentPhotoBox.Name = i_PhotoToAdd.PictureNormalURL;
            
            currentPhotoBox.Click += new System.EventHandler(pictureBox_Click);
            imagesFlowLayoutPanel.Controls.Add(currentPhotoBox);
        }

        public void SingleImageToShow(string i_ImageURL)
        {
            PictureBox singleImageBox = new PictureBox();
            singleImageBox.Load(i_ImageURL);
            singleImageBox.SizeMode = PictureBoxSizeMode.AutoSize;
            imagesFlowLayoutPanel.Controls.Add(singleImageBox);
        }
    }
}