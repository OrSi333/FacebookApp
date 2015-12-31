namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    partial class EventForm
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
            this.pictureBoxEventPhoto = new System.Windows.Forms.PictureBox();
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelEventDate = new System.Windows.Forms.Label();
            this.labelHostName = new System.Windows.Forms.Label();
            this.buttonGoing = new System.Windows.Forms.Button();
            this.buttonMaybe = new System.Windows.Forms.Button();
            this.buttonCantGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEventPhoto
            // 
            this.pictureBoxEventPhoto.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxEventPhoto.Name = "pictureBoxEventPhoto";
            this.pictureBoxEventPhoto.Size = new System.Drawing.Size(167, 105);
            this.pictureBoxEventPhoto.TabIndex = 0;
            this.pictureBoxEventPhoto.TabStop = false;
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(186, 12);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(63, 13);
            this.labelEventName.TabIndex = 1;
            this.labelEventName.Text = "EventName";
            // 
            // labelEventDate
            // 
            this.labelEventDate.AutoSize = true;
            this.labelEventDate.Location = new System.Drawing.Point(186, 33);
            this.labelEventDate.Name = "labelEventDate";
            this.labelEventDate.Size = new System.Drawing.Size(58, 13);
            this.labelEventDate.TabIndex = 2;
            this.labelEventDate.Text = "EventDate";
            // 
            // labelHostName
            // 
            this.labelHostName.AutoSize = true;
            this.labelHostName.Location = new System.Drawing.Point(186, 51);
            this.labelHostName.Name = "labelHostName";
            this.labelHostName.Size = new System.Drawing.Size(57, 13);
            this.labelHostName.TabIndex = 3;
            this.labelHostName.Text = "HostName";
            // 
            // buttonGoing
            // 
            this.buttonGoing.Location = new System.Drawing.Point(204, 80);
            this.buttonGoing.Name = "buttonGoing";
            this.buttonGoing.Size = new System.Drawing.Size(75, 23);
            this.buttonGoing.TabIndex = 4;
            this.buttonGoing.Text = "Going";
            this.buttonGoing.UseVisualStyleBackColor = true;
            this.buttonGoing.Click += new System.EventHandler(this.buttonGoing_Click);
            // 
            // buttonMaybe
            // 
            this.buttonMaybe.Location = new System.Drawing.Point(301, 80);
            this.buttonMaybe.Name = "buttonMaybe";
            this.buttonMaybe.Size = new System.Drawing.Size(75, 23);
            this.buttonMaybe.TabIndex = 5;
            this.buttonMaybe.Text = "Maybe";
            this.buttonMaybe.UseVisualStyleBackColor = true;
            this.buttonMaybe.Click += new System.EventHandler(this.buttonMaybe_Click);
            // 
            // buttonCantGo
            // 
            this.buttonCantGo.Location = new System.Drawing.Point(399, 80);
            this.buttonCantGo.Name = "buttonCantGo";
            this.buttonCantGo.Size = new System.Drawing.Size(75, 23);
            this.buttonCantGo.TabIndex = 6;
            this.buttonCantGo.Text = "Can\'t Go";
            this.buttonCantGo.UseVisualStyleBackColor = true;
            this.buttonCantGo.Click += new System.EventHandler(this.buttonCantGo_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 129);
            this.Controls.Add(this.buttonCantGo);
            this.Controls.Add(this.buttonMaybe);
            this.Controls.Add(this.buttonGoing);
            this.Controls.Add(this.labelHostName);
            this.Controls.Add(this.labelEventDate);
            this.Controls.Add(this.labelEventName);
            this.Controls.Add(this.pictureBoxEventPhoto);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEventPhoto;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Label labelEventDate;
        private System.Windows.Forms.Label labelHostName;
        private System.Windows.Forms.Button buttonGoing;
        private System.Windows.Forms.Button buttonMaybe;
        private System.Windows.Forms.Button buttonCantGo;
    }
}