namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    partial class UserSharedEventsForm
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
            this.userThumbnail = new System.Windows.Forms.PictureBox();
            this.userSharedEventsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.userThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // userThumbnail
            // 
            this.userThumbnail.Location = new System.Drawing.Point(13, 13);
            this.userThumbnail.Name = "userThumbnail";
            this.userThumbnail.Size = new System.Drawing.Size(100, 89);
            this.userThumbnail.TabIndex = 0;
            this.userThumbnail.TabStop = false;
            // 
            // userSharedEventsListBox
            // 
            this.userSharedEventsListBox.FormattingEnabled = true;
            this.userSharedEventsListBox.Location = new System.Drawing.Point(153, 17);
            this.userSharedEventsListBox.Name = "userSharedEventsListBox";
            this.userSharedEventsListBox.Size = new System.Drawing.Size(437, 186);
            this.userSharedEventsListBox.TabIndex = 1;
            // 
            // UserSharedEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 427);
            this.Controls.Add(this.userSharedEventsListBox);
            this.Controls.Add(this.userThumbnail);
            this.Name = "UserSharedEventsForm";
            this.Text = "UserSharedEvents";
            ((System.ComponentModel.ISupportInitialize)(this.userThumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox userThumbnail;
        private System.Windows.Forms.ListBox userSharedEventsListBox;
    }
}