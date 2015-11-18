namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    partial class Form1
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.tabControlFBFeatures = new System.Windows.Forms.TabControl();
            this.tabPagePost = new System.Windows.Forms.TabPage();
            this.Wall = new System.Windows.Forms.TabPage();
            this.buttonWallCommentLike = new System.Windows.Forms.Button();
            this.pictureBoxWallPost = new System.Windows.Forms.PictureBox();
            this.buttonWallNextPost = new System.Windows.Forms.Button();
            this.buttonWallPreviousPost = new System.Windows.Forms.Button();
            this.textBoxWallWriteComment = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelWallPost = new System.Windows.Forms.Label();
            this.listBoxWallComments = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewFriends = new System.Windows.Forms.DataGridView();
            this.m_ShowTags = new System.Windows.Forms.Button();
            this.m_FetchEventFriends = new System.Windows.Forms.Button();
            this.listBoxUndecidedEvents = new System.Windows.Forms.ListBox();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumberOfShared = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShowDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabControlFBFeatures.SuspendLayout();
            this.tabPagePost.SuspendLayout();
            this.Wall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallPost)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 25);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(6, 13);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(52, 50);
            this.pictureBoxProfile.TabIndex = 1;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(64, 28);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(228, 20);
            this.textBoxStatus.TabIndex = 2;
            this.textBoxStatus.Text = "What\'s on your mind?";
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(157)))));
            this.buttonPostStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPostStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPostStatus.Location = new System.Drawing.Point(370, 143);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(75, 32);
            this.buttonPostStatus.TabIndex = 3;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = false;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
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
            this.tabControlFBFeatures.Size = new System.Drawing.Size(459, 388);
            this.tabControlFBFeatures.TabIndex = 4;
            // 
            // tabPagePost
            // 
            this.tabPagePost.Controls.Add(this.buttonPostStatus);
            this.tabPagePost.Controls.Add(this.pictureBoxProfile);
            this.tabPagePost.Controls.Add(this.textBoxStatus);
            this.tabPagePost.Location = new System.Drawing.Point(4, 22);
            this.tabPagePost.Name = "tabPagePost";
            this.tabPagePost.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePost.Size = new System.Drawing.Size(451, 362);
            this.tabPagePost.TabIndex = 0;
            this.tabPagePost.Text = "Post";
            this.tabPagePost.UseVisualStyleBackColor = true;
            // 
            // Wall
            // 
            this.Wall.Controls.Add(this.buttonWallCommentLike);
            this.Wall.Controls.Add(this.pictureBoxWallPost);
            this.Wall.Controls.Add(this.buttonWallNextPost);
            this.Wall.Controls.Add(this.buttonWallPreviousPost);
            this.Wall.Controls.Add(this.textBoxWallWriteComment);
            this.Wall.Controls.Add(this.linkLabel1);
            this.Wall.Controls.Add(this.labelWallPost);
            this.Wall.Controls.Add(this.listBoxWallComments);
            this.Wall.Location = new System.Drawing.Point(4, 22);
            this.Wall.Name = "Wall";
            this.Wall.Size = new System.Drawing.Size(451, 362);
            this.Wall.TabIndex = 2;
            this.Wall.Text = "Wall";
            this.Wall.UseVisualStyleBackColor = true;
            // 
            // buttonWallCommentLike
            // 
            this.buttonWallCommentLike.Location = new System.Drawing.Point(379, 245);
            this.buttonWallCommentLike.Name = "buttonWallCommentLike";
            this.buttonWallCommentLike.Size = new System.Drawing.Size(60, 30);
            this.buttonWallCommentLike.TabIndex = 7;
            this.buttonWallCommentLike.Text = "Like";
            this.buttonWallCommentLike.UseVisualStyleBackColor = true;
            this.buttonWallCommentLike.Click += new System.EventHandler(this.buttonWallCommentLike_Click);
            // 
            // pictureBoxWallPost
            // 
            this.pictureBoxWallPost.Location = new System.Drawing.Point(19, 80);
            this.pictureBoxWallPost.Name = "pictureBoxWallPost";
            this.pictureBoxWallPost.Size = new System.Drawing.Size(222, 95);
            this.pictureBoxWallPost.TabIndex = 6;
            this.pictureBoxWallPost.TabStop = false;
            // 
            // buttonWallNextPost
            // 
            this.buttonWallNextPost.Location = new System.Drawing.Point(375, 317);
            this.buttonWallNextPost.Name = "buttonWallNextPost";
            this.buttonWallNextPost.Size = new System.Drawing.Size(64, 37);
            this.buttonWallNextPost.TabIndex = 5;
            this.buttonWallNextPost.Text = "Next Post";
            this.buttonWallNextPost.UseVisualStyleBackColor = true;
            // 
            // buttonWallPreviousPost
            // 
            this.buttonWallPreviousPost.Location = new System.Drawing.Point(375, 55);
            this.buttonWallPreviousPost.Name = "buttonWallPreviousPost";
            this.buttonWallPreviousPost.Size = new System.Drawing.Size(64, 37);
            this.buttonWallPreviousPost.TabIndex = 4;
            this.buttonWallPreviousPost.Text = "Previous Post";
            this.buttonWallPreviousPost.UseVisualStyleBackColor = true;
            // 
            // textBoxWallWriteComment
            // 
            this.textBoxWallWriteComment.Location = new System.Drawing.Point(19, 280);
            this.textBoxWallWriteComment.Name = "textBoxWallWriteComment";
            this.textBoxWallWriteComment.Size = new System.Drawing.Size(292, 20);
            this.textBoxWallWriteComment.TabIndex = 3;
            this.textBoxWallWriteComment.Text = "Write a comment...";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(317, 286);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(28, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Post";
            // 
            // labelWallPost
            // 
            this.labelWallPost.AutoSize = true;
            this.labelWallPost.Location = new System.Drawing.Point(16, 55);
            this.labelWallPost.Name = "labelWallPost";
            this.labelWallPost.Size = new System.Drawing.Size(28, 13);
            this.labelWallPost.TabIndex = 1;
            this.labelWallPost.Text = "Post";
            // 
            // listBoxWallComments
            // 
            this.listBoxWallComments.FormattingEnabled = true;
            this.listBoxWallComments.Location = new System.Drawing.Point(19, 181);
            this.listBoxWallComments.Name = "listBoxWallComments";
            this.listBoxWallComments.Size = new System.Drawing.Size(353, 95);
            this.listBoxWallComments.TabIndex = 0;
            this.listBoxWallComments.SelectedIndexChanged += new System.EventHandler(this.listBoxWallComments_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewFriends);
            this.tabPage2.Controls.Add(this.m_ShowTags);
            this.tabPage2.Controls.Add(this.m_FetchEventFriends);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(451, 362);
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
            // listBoxUndecidedEvents
            // 
            this.listBoxUndecidedEvents.FormattingEnabled = true;
            this.listBoxUndecidedEvents.Location = new System.Drawing.Point(586, 47);
            this.listBoxUndecidedEvents.Name = "listBoxUndecidedEvents";
            this.listBoxUndecidedEvents.Size = new System.Drawing.Size(237, 108);
            this.listBoxUndecidedEvents.TabIndex = 5;
            this.listBoxUndecidedEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxUndecidedEvents_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.HeaderText = "";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnNumberOfShared
            // 
            this.columnNumberOfShared.HeaderText = "";
            this.columnNumberOfShared.Name = "columnNumberOfShared";
            this.columnNumberOfShared.ReadOnly = true;
            // 
            // columnShowDetails
            // 
            this.columnShowDetails.HeaderText = "";
            this.columnShowDetails.Name = "columnShowDetails";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 425);
            this.Controls.Add(this.listBoxUndecidedEvents);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.tabControlFBFeatures);
            this.Name = "Form1";
            this.Text = "MyFBApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabControlFBFeatures.ResumeLayout(false);
            this.tabPagePost.ResumeLayout(false);
            this.tabPagePost.PerformLayout();
            this.Wall.ResumeLayout(false);
            this.Wall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallPost)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.TabControl tabControlFBFeatures;
        private System.Windows.Forms.TabPage tabPagePost;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxUndecidedEvents;
        private System.Windows.Forms.Button m_ShowTags;
        private System.Windows.Forms.Button m_FetchEventFriends;
        private System.Windows.Forms.DataGridView dataGridViewFriends;
        private System.Windows.Forms.TabPage Wall;
        private System.Windows.Forms.Button buttonWallNextPost;
        private System.Windows.Forms.Button buttonWallPreviousPost;
        private System.Windows.Forms.TextBox textBoxWallWriteComment;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelWallPost;
        private System.Windows.Forms.ListBox listBoxWallComments;
        private System.Windows.Forms.PictureBox pictureBoxWallPost;
        private System.Windows.Forms.Button buttonWallCommentLike;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumberOfShared;
        private System.Windows.Forms.DataGridViewButtonColumn columnShowDetails;
 }
}

