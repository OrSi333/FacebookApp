namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    partial class MyFBAppForm
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
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.TextBoxStatus = new System.Windows.Forms.TextBox();
            this.ButtonPostStatus = new System.Windows.Forms.Button();
            this.tabControlFBFeatures = new System.Windows.Forms.TabControl();
            this.tabPagePost = new System.Windows.Forms.TabPage();
            this.ListBoxUndecidedEvents = new System.Windows.Forms.ListBox();
            this.Wall = new System.Windows.Forms.TabPage();
            this.ButtonWallCommentLike = new System.Windows.Forms.Button();
            this.ListBoxWallPosts = new System.Windows.Forms.ListBox();
            this.PictureBoxWallPost = new System.Windows.Forms.PictureBox();
            this.TextBoxWallWriteComment = new System.Windows.Forms.TextBox();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LabelWallPost = new System.Windows.Forms.Label();
            this.ListBoxWallComments = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewFriends = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumberOfShared = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShowDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.m_ShowTags = new System.Windows.Forms.Button();
            this.m_FetchEventFriends = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            this.tabControlFBFeatures.SuspendLayout();
            this.tabPagePost.SuspendLayout();
            this.Wall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWallPost)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(12, 25);
            this.ButtonLogin.Name = "buttonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxProfile
            // 
            this.PictureBoxProfile.Location = new System.Drawing.Point(6, 13);
            this.PictureBoxProfile.Name = "pictureBoxProfile";
            this.PictureBoxProfile.Size = new System.Drawing.Size(52, 50);
            this.PictureBoxProfile.TabIndex = 1;
            this.PictureBoxProfile.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.TextBoxStatus.Location = new System.Drawing.Point(64, 28);
            this.TextBoxStatus.Name = "textBoxStatus";
            this.TextBoxStatus.Size = new System.Drawing.Size(228, 20);
            this.TextBoxStatus.TabIndex = 2;
            this.TextBoxStatus.Text = "What\'s on your mind?";
            // 
            // buttonPostStatus
            // 
            this.ButtonPostStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(157)))));
            this.ButtonPostStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonPostStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonPostStatus.Location = new System.Drawing.Point(370, 143);
            this.ButtonPostStatus.Name = "buttonPostStatus";
            this.ButtonPostStatus.Size = new System.Drawing.Size(75, 32);
            this.ButtonPostStatus.TabIndex = 3;
            this.ButtonPostStatus.Text = "Post";
            this.ButtonPostStatus.UseVisualStyleBackColor = false;
            this.ButtonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // tabControlFBFeatures
            // 
            this.tabControlFBFeatures.Controls.Add(this.tabPagePost);
            this.tabControlFBFeatures.Controls.Add(this.Wall);
            this.tabControlFBFeatures.Controls.Add(this.tabPage2);
            this.tabControlFBFeatures.Enabled = false;
            this.tabControlFBFeatures.Location = new System.Drawing.Point(107, 25);
            this.tabControlFBFeatures.Name = "tabControlFBFeatures";
            this.tabControlFBFeatures.SelectedIndex = 0;
            this.tabControlFBFeatures.Size = new System.Drawing.Size(829, 388);
            this.tabControlFBFeatures.TabIndex = 4;
            // 
            // tabPagePost
            // 
            this.tabPagePost.Controls.Add(this.ListBoxUndecidedEvents);
            this.tabPagePost.Controls.Add(this.ButtonPostStatus);
            this.tabPagePost.Controls.Add(this.PictureBoxProfile);
            this.tabPagePost.Controls.Add(this.TextBoxStatus);
            this.tabPagePost.Location = new System.Drawing.Point(4, 22);
            this.tabPagePost.Name = "tabPagePost";
            this.tabPagePost.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePost.Size = new System.Drawing.Size(821, 362);
            this.tabPagePost.TabIndex = 0;
            this.tabPagePost.Text = "Post";
            this.tabPagePost.UseVisualStyleBackColor = true;
            // 
            // listBoxUndecidedEvents
            // 
            this.ListBoxUndecidedEvents.FormattingEnabled = true;
            this.ListBoxUndecidedEvents.Location = new System.Drawing.Point(465, 28);
            this.ListBoxUndecidedEvents.Name = "listBoxUndecidedEvents";
            this.ListBoxUndecidedEvents.Size = new System.Drawing.Size(237, 186);
            this.ListBoxUndecidedEvents.TabIndex = 5;
            this.ListBoxUndecidedEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxUndecidedEvents_SelectedIndexChanged);
            // 
            // Wall
            // 
            this.Wall.Controls.Add(this.ButtonWallCommentLike);
            this.Wall.Controls.Add(this.ListBoxWallPosts);
            this.Wall.Controls.Add(this.PictureBoxWallPost);
            this.Wall.Controls.Add(this.TextBoxWallWriteComment);
            this.Wall.Controls.Add(this.LinkLabel1);
            this.Wall.Controls.Add(this.LabelWallPost);
            this.Wall.Controls.Add(this.ListBoxWallComments);
            this.Wall.Location = new System.Drawing.Point(4, 22);
            this.Wall.Name = "Wall";
            this.Wall.Size = new System.Drawing.Size(821, 362);
            this.Wall.TabIndex = 2;
            this.Wall.Text = "Wall";
            this.Wall.UseVisualStyleBackColor = true;
            // 
            // buttonWallCommentLike
            // 
            this.ButtonWallCommentLike.Location = new System.Drawing.Point(379, 291);
            this.ButtonWallCommentLike.Name = "buttonWallCommentLike";
            this.ButtonWallCommentLike.Size = new System.Drawing.Size(60, 30);
            this.ButtonWallCommentLike.TabIndex = 7;
            this.ButtonWallCommentLike.Text = "Like";
            this.ButtonWallCommentLike.UseVisualStyleBackColor = true;
            this.ButtonWallCommentLike.Visible = false;
            this.ButtonWallCommentLike.Click += new System.EventHandler(this.buttonWallCommentLike_Click);
            // 
            // listBoxWallPosts
            // 
            this.ListBoxWallPosts.FormattingEnabled = true;
            this.ListBoxWallPosts.Location = new System.Drawing.Point(468, 55);
            this.ListBoxWallPosts.Name = "listBoxWallPosts";
            this.ListBoxWallPosts.Size = new System.Drawing.Size(339, 290);
            this.ListBoxWallPosts.TabIndex = 6;
            this.ListBoxWallPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxWallPosts_SelectedIndexChanged);
            // 
            // pictureBoxWallPost
            // 
            this.PictureBoxWallPost.Location = new System.Drawing.Point(19, 126);
            this.PictureBoxWallPost.Name = "pictureBoxWallPost";
            this.PictureBoxWallPost.Size = new System.Drawing.Size(222, 95);
            this.PictureBoxWallPost.TabIndex = 6;
            this.PictureBoxWallPost.TabStop = false;
            // 
            // textBoxWallWriteComment
            // 
            this.TextBoxWallWriteComment.Location = new System.Drawing.Point(19, 326);
            this.TextBoxWallWriteComment.Name = "textBoxWallWriteComment";
            this.TextBoxWallWriteComment.Size = new System.Drawing.Size(292, 20);
            this.TextBoxWallWriteComment.TabIndex = 3;
            this.TextBoxWallWriteComment.Text = "Write a comment...";
            // 
            // linkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Location = new System.Drawing.Point(317, 332);
            this.LinkLabel1.Name = "linkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(28, 13);
            this.LinkLabel1.TabIndex = 2;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Post";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelWallPost
            // 
            this.LabelWallPost.Location = new System.Drawing.Point(16, 55);
            this.LabelWallPost.Name = "labelWallPost";
            this.LabelWallPost.Size = new System.Drawing.Size(423, 68);
            this.LabelWallPost.TabIndex = 1;
            this.LabelWallPost.Text = "Post";
            // 
            // listBoxWallComments
            // 
            this.ListBoxWallComments.FormattingEnabled = true;
            this.ListBoxWallComments.Location = new System.Drawing.Point(19, 227);
            this.ListBoxWallComments.Name = "listBoxWallComments";
            this.ListBoxWallComments.Size = new System.Drawing.Size(353, 95);
            this.ListBoxWallComments.TabIndex = 0;
            this.ListBoxWallComments.SelectedIndexChanged += new System.EventHandler(this.listBoxWallComments_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewFriends);
            this.tabPage2.Controls.Add(this.m_ShowTags);
            this.tabPage2.Controls.Add(this.m_FetchEventFriends);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(708, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Special Features";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFriends
            // 
            this.dataGridViewFriends.AllowUserToAddRows = false;
            this.dataGridViewFriends.AllowUserToDeleteRows = false;
            this.dataGridViewFriends.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriends.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnNumberOfShared,
            this.columnShowDetails});
            this.dataGridViewFriends.Location = new System.Drawing.Point(6, 67);
            this.dataGridViewFriends.Name = "dataGridViewFriends";
            this.dataGridViewFriends.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFriends.Size = new System.Drawing.Size(439, 289);
            this.dataGridViewFriends.TabIndex = 2;
            this.dataGridViewFriends.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFriends_CellDoubleClick);
            // 
            // columnName
            // 
            this.columnName.HeaderText = string.Empty;
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnNumberOfShared
            // 
            this.columnNumberOfShared.HeaderText = string.Empty;
            this.columnNumberOfShared.Name = "columnNumberOfShared";
            this.columnNumberOfShared.ReadOnly = true;
            // 
            // columnShowDetails
            // 
            this.columnShowDetails.HeaderText = string.Empty;
            this.columnShowDetails.Name = "columnShowDetails";
            // 
            // m_ShowTags
            // 
            this.m_ShowTags.Location = new System.Drawing.Point(6, 6);
            this.m_ShowTags.Name = "m_ShowTags";
            this.m_ShowTags.Size = new System.Drawing.Size(98, 55);
            this.m_ShowTags.TabIndex = 1;
            this.m_ShowTags.Text = "Friends Most Tagged With Me";
            this.m_ShowTags.UseVisualStyleBackColor = true;
            this.m_ShowTags.Click += new System.EventHandler(this.m_ShowTags_Click);
            // 
            // m_FetchEventFriends
            // 
            this.m_FetchEventFriends.Location = new System.Drawing.Point(276, 6);
            this.m_FetchEventFriends.Name = "m_FetchEventFriends";
            this.m_FetchEventFriends.Size = new System.Drawing.Size(106, 55);
            this.m_FetchEventFriends.TabIndex = 0;
            this.m_FetchEventFriends.Text = "People Who Go To Same Events As Me";
            this.m_FetchEventFriends.UseVisualStyleBackColor = true;
            this.m_FetchEventFriends.Click += new System.EventHandler(this.m_FetchEventFriends_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 425);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.tabControlFBFeatures);
            this.Name = "Form1";
            this.Text = "MyFBApp";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            this.tabControlFBFeatures.ResumeLayout(false);
            this.tabPagePost.ResumeLayout(false);
            this.tabPagePost.PerformLayout();
            this.Wall.ResumeLayout(false);
            this.Wall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWallPost)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFBFeatures;
        private System.Windows.Forms.TabPage tabPagePost;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button m_ShowTags;
        private System.Windows.Forms.Button m_FetchEventFriends;
        private System.Windows.Forms.DataGridView dataGridViewFriends;
        private System.Windows.Forms.TabPage Wall;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumberOfShared;
        private System.Windows.Forms.DataGridViewButtonColumn columnShowDetails;
        internal System.Windows.Forms.Button ButtonLogin;
        internal System.Windows.Forms.PictureBox PictureBoxProfile;
        internal System.Windows.Forms.TextBox TextBoxStatus;
        internal System.Windows.Forms.Button ButtonPostStatus;
        internal System.Windows.Forms.ListBox ListBoxUndecidedEvents;
        internal System.Windows.Forms.TextBox TextBoxWallWriteComment;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.Label LabelWallPost;
        internal System.Windows.Forms.ListBox ListBoxWallComments;
        internal System.Windows.Forms.PictureBox PictureBoxWallPost;
        internal System.Windows.Forms.Button ButtonWallCommentLike;
        internal System.Windows.Forms.ListBox ListBoxWallPosts;
 }
}