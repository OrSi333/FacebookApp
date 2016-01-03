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
            this.components = new System.ComponentModel.Container();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.TextBoxStatus = new System.Windows.Forms.TextBox();
            this.ButtonPostStatus = new System.Windows.Forms.Button();
            this.tabControlFBFeatures = new System.Windows.Forms.TabControl();
            this.tabPagePost = new System.Windows.Forms.TabPage();
            this.ListBoxUndecidedEvents = new System.Windows.Forms.ListBox();
            this.Wall = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commentsListBox = new System.Windows.Forms.ListBox();
            this.commentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonWallCommentLike = new System.Windows.Forms.Button();
            this.pictureURLPictureBox = new System.Windows.Forms.PictureBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageLabel1 = new System.Windows.Forms.Label();
            this.ListBoxWallPosts = new System.Windows.Forms.ListBox();
            this.TextBoxWallWriteComment = new System.Windows.Forms.TextBox();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxFriendsWithRank = new System.Windows.Forms.ListBox();
            this.m_ShowTags = new System.Windows.Forms.Button();
            this.m_FetchEventFriends = new System.Windows.Forms.Button();
            this.m_PanelSharedImagesWithFriend = new System.Windows.Forms.Panel();
            this.m_FlowLayoutPanelSharedImages = new System.Windows.Forms.FlowLayoutPanel();
            this.m_PanelPeopleInSameEvents = new System.Windows.Forms.Panel();
            this.m_ListBoxSharedEvents = new System.Windows.Forms.ListBox();
            this.m_PictureBoxUserFromSharedEvents = new System.Windows.Forms.PictureBox();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureSqaureURLPictureBox = new System.Windows.Forms.PictureBox();
            this.notYetRepliedUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            this.tabControlFBFeatures.SuspendLayout();
            this.tabPagePost.SuspendLayout();
            this.Wall.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.m_PanelSharedImagesWithFriend.SuspendLayout();
            this.m_PanelPeopleInSameEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxUserFromSharedEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSqaureURLPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notYetRepliedUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(12, 25);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // PictureBoxProfile
            // 
            this.PictureBoxProfile.Location = new System.Drawing.Point(6, 13);
            this.PictureBoxProfile.Name = "PictureBoxProfile";
            this.PictureBoxProfile.Size = new System.Drawing.Size(52, 50);
            this.PictureBoxProfile.TabIndex = 1;
            this.PictureBoxProfile.TabStop = false;
            // 
            // TextBoxStatus
            // 
            this.TextBoxStatus.Location = new System.Drawing.Point(64, 28);
            this.TextBoxStatus.Name = "TextBoxStatus";
            this.TextBoxStatus.Size = new System.Drawing.Size(228, 20);
            this.TextBoxStatus.TabIndex = 2;
            this.TextBoxStatus.Text = "What\'s on your mind?";
            // 
            // ButtonPostStatus
            // 
            this.ButtonPostStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(157)))));
            this.ButtonPostStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonPostStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonPostStatus.Location = new System.Drawing.Point(370, 143);
            this.ButtonPostStatus.Name = "ButtonPostStatus";
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
            this.tabPagePost.AutoScroll = true;
            this.tabPagePost.Controls.Add(this.userListBox);
            this.tabPagePost.Controls.Add(this.pictureSqaureURLPictureBox);
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
            // ListBoxUndecidedEvents
            // 
            this.ListBoxUndecidedEvents.FormattingEnabled = true;
            this.ListBoxUndecidedEvents.Location = new System.Drawing.Point(465, 28);
            this.ListBoxUndecidedEvents.Name = "ListBoxUndecidedEvents";
            this.ListBoxUndecidedEvents.Size = new System.Drawing.Size(237, 186);
            this.ListBoxUndecidedEvents.TabIndex = 5;
            this.ListBoxUndecidedEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxUndecidedEvents_SelectedIndexChanged);
            // 
            // Wall
            // 
            this.Wall.AutoScroll = true;
            this.Wall.Controls.Add(this.panel1);
            this.Wall.Controls.Add(this.ListBoxWallPosts);
            this.Wall.Controls.Add(this.TextBoxWallWriteComment);
            this.Wall.Controls.Add(this.LinkLabel1);
            this.Wall.Location = new System.Drawing.Point(4, 22);
            this.Wall.Name = "Wall";
            this.Wall.Size = new System.Drawing.Size(821, 362);
            this.Wall.TabIndex = 2;
            this.Wall.Text = "Wall";
            this.Wall.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.commentsListBox);
            this.panel1.Controls.Add(this.ButtonWallCommentLike);
            this.panel1.Controls.Add(this.pictureURLPictureBox);
            this.panel1.Controls.Add(this.messageLabel1);
            this.panel1.Location = new System.Drawing.Point(19, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 304);
            this.panel1.TabIndex = 8;
            // 
            // commentsListBox
            // 
            this.commentsListBox.DataSource = this.commentsBindingSource1;
            this.commentsListBox.DisplayMember = "Message";
            this.commentsListBox.FormattingEnabled = true;
            this.commentsListBox.Location = new System.Drawing.Point(17, 166);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(300, 69);
            this.commentsListBox.TabIndex = 4;
            this.commentsListBox.ValueMember = "Comments";
            // 
            // ButtonWallCommentLike
            // 
            this.ButtonWallCommentLike.Location = new System.Drawing.Point(359, 261);
            this.ButtonWallCommentLike.Name = "ButtonWallCommentLike";
            this.ButtonWallCommentLike.Size = new System.Drawing.Size(60, 30);
            this.ButtonWallCommentLike.TabIndex = 7;
            this.ButtonWallCommentLike.Text = "Like";
            this.ButtonWallCommentLike.UseVisualStyleBackColor = true;
            this.ButtonWallCommentLike.Click += new System.EventHandler(this.buttonWallCommentLike_Click);
            // 
            // pictureURLPictureBox
            // 
            this.pictureURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.postBindingSource, "PictureURL", true));
            this.pictureURLPictureBox.Location = new System.Drawing.Point(17, 91);
            this.pictureURLPictureBox.Name = "pictureURLPictureBox";
            this.pictureURLPictureBox.Size = new System.Drawing.Size(100, 50);
            this.pictureURLPictureBox.TabIndex = 3;
            this.pictureURLPictureBox.TabStop = false;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // messageLabel1
            // 
            this.messageLabel1.AutoSize = true;
            this.messageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageLabel1.Location = new System.Drawing.Point(14, 37);
            this.messageLabel1.Name = "messageLabel1";
            this.messageLabel1.Size = new System.Drawing.Size(35, 13);
            this.messageLabel1.TabIndex = 1;
            this.messageLabel1.Text = "label1";
            // 
            // ListBoxWallPosts
            // 
            this.ListBoxWallPosts.Location = new System.Drawing.Point(457, 16);
            this.ListBoxWallPosts.Name = "ListBoxWallPosts";
            this.ListBoxWallPosts.Size = new System.Drawing.Size(350, 303);
            this.ListBoxWallPosts.TabIndex = 9;
            // 
            // TextBoxWallWriteComment
            // 
            this.TextBoxWallWriteComment.Location = new System.Drawing.Point(19, 326);
            this.TextBoxWallWriteComment.Name = "TextBoxWallWriteComment";
            this.TextBoxWallWriteComment.Size = new System.Drawing.Size(292, 20);
            this.TextBoxWallWriteComment.TabIndex = 3;
            this.TextBoxWallWriteComment.Text = "Write a comment...";
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Location = new System.Drawing.Point(317, 332);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(28, 13);
            this.LinkLabel1.TabIndex = 2;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Post";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxFriendsWithRank);
            this.tabPage2.Controls.Add(this.m_ShowTags);
            this.tabPage2.Controls.Add(this.m_FetchEventFriends);
            this.tabPage2.Controls.Add(this.m_PanelSharedImagesWithFriend);
            this.tabPage2.Controls.Add(this.m_PanelPeopleInSameEvents);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Special Features";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxFriendsWithRank
            // 
            this.listBoxFriendsWithRank.DisplayMember = "NameCount";
            this.listBoxFriendsWithRank.FormattingEnabled = true;
            this.listBoxFriendsWithRank.Location = new System.Drawing.Point(6, 67);
            this.listBoxFriendsWithRank.Name = "listBoxFriendsWithRank";
            this.listBoxFriendsWithRank.Size = new System.Drawing.Size(269, 290);
            this.listBoxFriendsWithRank.TabIndex = 3;
            this.listBoxFriendsWithRank.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendsWithRank_SelectedIndexChanged);
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
            this.m_FetchEventFriends.Location = new System.Drawing.Point(169, 6);
            this.m_FetchEventFriends.Name = "m_FetchEventFriends";
            this.m_FetchEventFriends.Size = new System.Drawing.Size(106, 55);
            this.m_FetchEventFriends.TabIndex = 0;
            this.m_FetchEventFriends.Text = "People Who Go To Same Events As Me";
            this.m_FetchEventFriends.UseVisualStyleBackColor = true;
            this.m_FetchEventFriends.Click += new System.EventHandler(this.m_FetchEventFriends_Click);
            // 
            // m_PanelSharedImagesWithFriend
            // 
            this.m_PanelSharedImagesWithFriend.Controls.Add(this.m_FlowLayoutPanelSharedImages);
            this.m_PanelSharedImagesWithFriend.Location = new System.Drawing.Point(281, 11);
            this.m_PanelSharedImagesWithFriend.Name = "m_PanelSharedImagesWithFriend";
            this.m_PanelSharedImagesWithFriend.Size = new System.Drawing.Size(533, 355);
            this.m_PanelSharedImagesWithFriend.TabIndex = 2;
            this.m_PanelSharedImagesWithFriend.Visible = false;
            // 
            // m_FlowLayoutPanelSharedImages
            // 
            this.m_FlowLayoutPanelSharedImages.Location = new System.Drawing.Point(4, 56);
            this.m_FlowLayoutPanelSharedImages.Name = "m_FlowLayoutPanelSharedImages";
            this.m_FlowLayoutPanelSharedImages.Size = new System.Drawing.Size(509, 292);
            this.m_FlowLayoutPanelSharedImages.TabIndex = 0;
            // 
            // m_PanelPeopleInSameEvents
            // 
            this.m_PanelPeopleInSameEvents.Controls.Add(this.m_ListBoxSharedEvents);
            this.m_PanelPeopleInSameEvents.Controls.Add(this.m_PictureBoxUserFromSharedEvents);
            this.m_PanelPeopleInSameEvents.Location = new System.Drawing.Point(282, 7);
            this.m_PanelPeopleInSameEvents.Name = "m_PanelPeopleInSameEvents";
            this.m_PanelPeopleInSameEvents.Size = new System.Drawing.Size(536, 349);
            this.m_PanelPeopleInSameEvents.TabIndex = 4;
            this.m_PanelPeopleInSameEvents.Visible = false;
            // 
            // m_ListBoxSharedEvents
            // 
            this.m_ListBoxSharedEvents.FormattingEnabled = true;
            this.m_ListBoxSharedEvents.Location = new System.Drawing.Point(87, 60);
            this.m_ListBoxSharedEvents.Name = "m_ListBoxSharedEvents";
            this.m_ListBoxSharedEvents.Size = new System.Drawing.Size(374, 238);
            this.m_ListBoxSharedEvents.TabIndex = 1;
            // 
            // m_PictureBoxUserFromSharedEvents
            // 
            this.m_PictureBoxUserFromSharedEvents.Location = new System.Drawing.Point(3, 60);
            this.m_PictureBoxUserFromSharedEvents.Name = "m_PictureBoxUserFromSharedEvents";
            this.m_PictureBoxUserFromSharedEvents.Size = new System.Drawing.Size(50, 50);
            this.m_PictureBoxUserFromSharedEvents.TabIndex = 0;
            this.m_PictureBoxUserFromSharedEvents.TabStop = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // pictureSqaureURLPictureBox
            // 
            this.pictureSqaureURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "PictureSqaureURL", true));
            this.pictureSqaureURLPictureBox.Location = new System.Drawing.Point(18, 87);
            this.pictureSqaureURLPictureBox.Name = "pictureSqaureURLPictureBox";
            this.pictureSqaureURLPictureBox.Size = new System.Drawing.Size(100, 50);
            this.pictureSqaureURLPictureBox.TabIndex = 6;
            this.pictureSqaureURLPictureBox.TabStop = false;
            // 
            // notYetRepliedUsersBindingSource
            // 
            this.notYetRepliedUsersBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // userListBox
            // 
            this.userListBox.DataSource = this.notYetRepliedUsersBindingSource;
            this.userListBox.DisplayMember = "Bio";
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(64, 210);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(300, 212);
            this.userListBox.TabIndex = 6;
            this.userListBox.ValueMember = "Albums";
            // 
            // MyFBAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 425);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.tabControlFBFeatures);
            this.Name = "MyFBAppForm";
            this.Text = "MyFBApp";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            this.tabControlFBFeatures.ResumeLayout(false);
            this.tabPagePost.ResumeLayout(false);
            this.tabPagePost.PerformLayout();
            this.Wall.ResumeLayout(false);
            this.Wall.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.m_PanelSharedImagesWithFriend.ResumeLayout(false);
            this.m_PanelPeopleInSameEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxUserFromSharedEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSqaureURLPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notYetRepliedUsersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFBFeatures;
        private System.Windows.Forms.TabPage tabPagePost;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button m_ShowTags;
        private System.Windows.Forms.Button m_FetchEventFriends;
        private System.Windows.Forms.TabPage Wall;
        internal System.Windows.Forms.Button ButtonLogin;
        internal System.Windows.Forms.PictureBox PictureBoxProfile;
        internal System.Windows.Forms.TextBox TextBoxStatus;
        internal System.Windows.Forms.Button ButtonPostStatus;
        internal System.Windows.Forms.ListBox ListBoxUndecidedEvents;
        internal System.Windows.Forms.TextBox TextBoxWallWriteComment;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.Button ButtonWallCommentLike;
        internal System.Windows.Forms.ListBox ListBoxWallPosts;
        private System.Windows.Forms.ListBox listBoxFriendsWithRank;
        private System.Windows.Forms.Panel m_PanelPeopleInSameEvents;
        private System.Windows.Forms.ListBox m_ListBoxSharedEvents;
        private System.Windows.Forms.PictureBox m_PictureBoxUserFromSharedEvents;
        private System.Windows.Forms.Panel m_PanelSharedImagesWithFriend;
        private System.Windows.Forms.FlowLayoutPanel m_FlowLayoutPanelSharedImages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureURLPictureBox;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Label messageLabel1;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.ListBox commentsListBox;
        private System.Windows.Forms.BindingSource commentsBindingSource1;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.BindingSource notYetRepliedUsersBindingSource;
        private System.Windows.Forms.PictureBox pictureSqaureURLPictureBox;
        private System.Windows.Forms.BindingSource userBindingSource;
 }
}