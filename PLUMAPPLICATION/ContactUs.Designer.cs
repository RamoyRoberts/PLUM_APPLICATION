namespace PLUMAPPLICATION
{
    partial class ContactUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactUs));
            this.pictureBoxTractor = new System.Windows.Forms.PictureBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.TBYourMessage = new System.Windows.Forms.TextBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelAboutUs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxSocial = new System.Windows.Forms.PictureBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusAboutUs = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIconContactUs = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSocial)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTractor
            // 
            this.pictureBoxTractor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTractor.BackgroundImage")));
            this.pictureBoxTractor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTractor.Location = new System.Drawing.Point(0, 1);
            this.pictureBoxTractor.Name = "pictureBoxTractor";
            this.pictureBoxTractor.Size = new System.Drawing.Size(1457, 197);
            this.pictureBoxTractor.TabIndex = 0;
            this.pictureBoxTractor.TabStop = false;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(15, 221);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(539, 20);
            this.TBName.TabIndex = 1;
            this.TBName.MouseLeave += new System.EventHandler(this.TBName_MouseLeave);
            this.TBName.MouseHover += new System.EventHandler(this.TBName_MouseHover);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 197);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 24);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(12, 275);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(542, 20);
            this.TBEmail.TabIndex = 3;
            this.TBEmail.MouseLeave += new System.EventHandler(this.TBEmail_MouseLeave);
            this.TBEmail.MouseHover += new System.EventHandler(this.TBEmail_MouseHover);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(12, 250);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(62, 24);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email:";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(9, 318);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(137, 24);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "Your Message:";
            // 
            // TBYourMessage
            // 
            this.TBYourMessage.Location = new System.Drawing.Point(12, 345);
            this.TBYourMessage.Multiline = true;
            this.TBYourMessage.Name = "TBYourMessage";
            this.TBYourMessage.Size = new System.Drawing.Size(542, 163);
            this.TBYourMessage.TabIndex = 6;
            this.TBYourMessage.MouseLeave += new System.EventHandler(this.TBYourMessage_MouseLeave);
            this.TBYourMessage.MouseHover += new System.EventHandler(this.TBYourMessage_MouseHover);
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendMessage.ForeColor = System.Drawing.Color.White;
            this.buttonSendMessage.Location = new System.Drawing.Point(38, 518);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(122, 38);
            this.buttonSendMessage.TabIndex = 7;
            this.buttonSendMessage.Text = "&Send Message";
            this.buttonSendMessage.UseVisualStyleBackColor = false;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(400, 518);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 38);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "&CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelAboutUs
            // 
            this.labelAboutUs.AutoSize = true;
            this.labelAboutUs.BackColor = System.Drawing.Color.Teal;
            this.labelAboutUs.Font = new System.Drawing.Font("Britannic Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutUs.ForeColor = System.Drawing.Color.White;
            this.labelAboutUs.Location = new System.Drawing.Point(1112, 202);
            this.labelAboutUs.Name = "labelAboutUs";
            this.labelAboutUs.Size = new System.Drawing.Size(187, 48);
            this.labelAboutUs.TabIndex = 9;
            this.labelAboutUs.Text = "About Us";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(991, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Follow Us On Social Media:";
            // 
            // pictureBoxSocial
            // 
            this.pictureBoxSocial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSocial.BackgroundImage")));
            this.pictureBoxSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSocial.Location = new System.Drawing.Point(994, 468);
            this.pictureBoxSocial.Name = "pictureBoxSocial";
            this.pictureBoxSocial.Size = new System.Drawing.Size(399, 77);
            this.pictureBoxSocial.TabIndex = 12;
            this.pictureBoxSocial.TabStop = false;
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfo.Location = new System.Drawing.Point(994, 257);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(434, 163);
            this.tbInfo.TabIndex = 18;
            this.tbInfo.Text = resources.GetString("tbInfo.Text");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusAboutUs});
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1457, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusAboutUs
            // 
            this.toolStripStatusAboutUs.Name = "toolStripStatusAboutUs";
            this.toolStripStatusAboutUs.Size = new System.Drawing.Size(0, 17);
            // 
            // notifyIconContactUs
            // 
            this.notifyIconContactUs.Visible = true;
            // 
            // ContactUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 581);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.pictureBoxSocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAboutUs);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.TBYourMessage);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.pictureBoxTractor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactUs";
            this.Text = "ContactForm";
            this.SizeChanged += new System.EventHandler(this.ContactUs_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSocial)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTractor;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox TBYourMessage;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelAboutUs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxSocial;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusAboutUs;
        private System.Windows.Forms.NotifyIcon notifyIconContactUs;
    }
}