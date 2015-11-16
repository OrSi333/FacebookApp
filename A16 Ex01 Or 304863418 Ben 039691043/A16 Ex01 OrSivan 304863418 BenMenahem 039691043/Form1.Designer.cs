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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewFriends = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumberOfShared = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShowDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.m_ShowTags = new System.Windows.Forms.Button();
            this.m_FetchEventFriends = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.pictureBoxProfile.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(52, 50);
            this.pictureBoxProfile.TabIndex = 1;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(64, 21);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(228, 20);
            this.textBoxStatus.TabIndex = 2;
            this.textBoxStatus.Text = "What\'s on your mind?";
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(157)))));
            this.buttonPostStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPostStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPostStatus.Location = new System.Drawing.Point(370, 136);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(75, 32);
            this.buttonPostStatus.TabIndex = 3;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = false;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(107, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 388);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonPostStatus);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.textBoxStatus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(451, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Text = "tabPage2";
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
            this.dataGridViewFriends.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewFriends.Name = "dataGridViewFriends";
            this.dataGridViewFriends.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFriends.Size = new System.Drawing.Size(439, 321);
            this.dataGridViewFriends.TabIndex = 2;
            dataGridViewFriends.CellDoubleClick += dataGridViewFriends_CellDoubleClick;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnNumberOfShared
            // 
            this.columnNumberOfShared.HeaderText = "Number";
            this.columnNumberOfShared.Name = "columnNumberOfShared";
            this.columnNumberOfShared.ReadOnly = true;
            // 
            // columnShowDetails
            // 
            this.columnShowDetails.HeaderText = "Show Me";
            this.columnShowDetails.Name = "columnShowDetails";
            // 
            // m_ShowTags
            // 
            this.m_ShowTags.Location = new System.Drawing.Point(177, 6);
            this.m_ShowTags.Name = "m_ShowTags";
            this.m_ShowTags.Size = new System.Drawing.Size(75, 23);
            this.m_ShowTags.TabIndex = 1;
            this.m_ShowTags.Text = "Show Tags";
            this.m_ShowTags.UseVisualStyleBackColor = true;
            this.m_ShowTags.Click += new System.EventHandler(this.m_ShowTags_Click);
            // 
            // m_FetchEventFriends
            // 
            this.m_FetchEventFriends.Location = new System.Drawing.Point(6, 6);
            this.m_FetchEventFriends.Name = "m_FetchEventFriends";
            this.m_FetchEventFriends.Size = new System.Drawing.Size(105, 23);
            this.m_FetchEventFriends.TabIndex = 0;
            this.m_FetchEventFriends.Text = "Show Events";
            this.m_FetchEventFriends.UseVisualStyleBackColor = true;
            this.m_FetchEventFriends.Click += new System.EventHandler(this.m_FetchEventFriends_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(586, 47);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(237, 108);
            this.listBoxEvents.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 425);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button m_ShowTags;
        private System.Windows.Forms.Button m_FetchEventFriends;
        private System.Windows.Forms.DataGridView dataGridViewFriends;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumberOfShared;
        private System.Windows.Forms.DataGridViewButtonColumn columnShowDetails;

    }
}

