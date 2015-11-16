using FacebookWrapper.ObjectModel;
using System.Windows.Forms;
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
            this.imagesFlowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.imagesFlowLayoutPanel.Name = "imagesFlowLayoutPanel";
            this.imagesFlowLayoutPanel.Size = new System.Drawing.Size(527, 474);
            this.imagesFlowLayoutPanel.TabIndex = 1;
            // 
            // ImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 498);
            this.Controls.Add(this.imagesFlowLayoutPanel);
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
            imagesFlowLayoutPanel.Controls.Add(currentPhotoBox);
        }
    }
}