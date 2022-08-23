namespace PLUMAPPLICATION
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.MenuStripHomepage = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemLogo = new System.Windows.Forms.ToolStripMenuItem();
            this.ProduceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProduceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ContactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelPlum = new System.Windows.Forms.Label();
            this.statusStripInfo = new System.Windows.Forms.StatusStrip();
            this.logintext = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIconHome = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuStripHomepage.SuspendLayout();
            this.statusStripInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripHomepage
            // 
            this.MenuStripHomepage.BackColor = System.Drawing.Color.Teal;
            this.MenuStripHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuStripHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStripHomepage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLogo});
            this.MenuStripHomepage.Location = new System.Drawing.Point(0, 0);
            this.MenuStripHomepage.Name = "MenuStripHomepage";
            this.MenuStripHomepage.Size = new System.Drawing.Size(1457, 28);
            this.MenuStripHomepage.TabIndex = 2;
            this.MenuStripHomepage.Text = "menuStrip1";
            // 
            // toolStripMenuItemLogo
            // 
            this.toolStripMenuItemLogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProduceToolStripMenuItem1,
            this.AboutUsToolStripMenuItem1,
            this.ContactUsToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.toolStripMenuItemLogo.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemLogo.Name = "toolStripMenuItemLogo";
            this.toolStripMenuItemLogo.Size = new System.Drawing.Size(39, 24);
            this.toolStripMenuItemLogo.Text = "|||";
            // 
            // ProduceToolStripMenuItem1
            // 
            this.ProduceToolStripMenuItem1.BackColor = System.Drawing.Color.Teal;
            this.ProduceToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProduceToolStripMenuItem,
            this.purchaseToolStripMenuItem});
            this.ProduceToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.ProduceToolStripMenuItem1.Name = "ProduceToolStripMenuItem1";
            this.ProduceToolStripMenuItem1.Size = new System.Drawing.Size(194, 24);
            this.ProduceToolStripMenuItem1.Text = "Produce";
            // 
            // viewProduceToolStripMenuItem
            // 
            this.viewProduceToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.viewProduceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewProduceToolStripMenuItem.Name = "viewProduceToolStripMenuItem";
            this.viewProduceToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.viewProduceToolStripMenuItem.Text = "View Produce";
            this.viewProduceToolStripMenuItem.Click += new System.EventHandler(this.viewProduceToolStripMenuItem_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.purchaseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // AboutUsToolStripMenuItem1
            // 
            this.AboutUsToolStripMenuItem1.BackColor = System.Drawing.Color.Teal;
            this.AboutUsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.AboutUsToolStripMenuItem1.Name = "AboutUsToolStripMenuItem1";
            this.AboutUsToolStripMenuItem1.Size = new System.Drawing.Size(194, 24);
            this.AboutUsToolStripMenuItem1.Text = "About Us";
            this.AboutUsToolStripMenuItem1.Click += new System.EventHandler(this.AboutUsToolStripMenuItem1_Click);
            // 
            // ContactUsToolStripMenuItem
            // 
            this.ContactUsToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.ContactUsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem";
            this.ContactUsToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.ContactUsToolStripMenuItem.Text = "Contact Us";
            this.ContactUsToolStripMenuItem.Click += new System.EventHandler(this.ContactUsToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.manageUsersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // LabelPlum
            // 
            this.LabelPlum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelPlum.AutoSize = true;
            this.LabelPlum.BackColor = System.Drawing.Color.Teal;
            this.LabelPlum.Font = new System.Drawing.Font("Rockwell Extra Bold", 35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlum.ForeColor = System.Drawing.Color.White;
            this.LabelPlum.Location = new System.Drawing.Point(1217, 0);
            this.LabelPlum.Name = "LabelPlum";
            this.LabelPlum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelPlum.Size = new System.Drawing.Size(239, 55);
            this.LabelPlum.TabIndex = 3;
            this.LabelPlum.Text = "P.L.U.M";
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.BackColor = System.Drawing.Color.White;
            this.statusStripInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logintext});
            this.statusStripInfo.Location = new System.Drawing.Point(0, 559);
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(1457, 22);
            this.statusStripInfo.TabIndex = 5;
            // 
            // logintext
            // 
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(0, 17);
            // 
            // notifyIconHome
            // 
            this.notifyIconHome.Visible = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1457, 581);
            this.Controls.Add(this.statusStripInfo);
            this.Controls.Add(this.LabelPlum);
            this.Controls.Add(this.MenuStripHomepage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "HomePage";
            this.Text = "Farmer Management Systems";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.SizeChanged += new System.EventHandler(this.HomePage_SizeChanged);
            this.MenuStripHomepage.ResumeLayout(false);
            this.MenuStripHomepage.PerformLayout();
            this.statusStripInfo.ResumeLayout(false);
            this.statusStripInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripHomepage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogo;
        private System.Windows.Forms.ToolStripMenuItem ProduceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AboutUsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ContactUsToolStripMenuItem;
        private System.Windows.Forms.Label LabelPlum;
        private System.Windows.Forms.ToolStripMenuItem viewProduceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripInfo;
        private System.Windows.Forms.ToolStripStatusLabel logintext;
        private System.Windows.Forms.NotifyIcon notifyIconHome;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}