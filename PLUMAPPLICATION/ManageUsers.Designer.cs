namespace PLUMAPPLICATION
{
    partial class ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.buttonDeactivateUser = new System.Windows.Forms.Button();
            this.buttonResetPassword = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.labelManageUsers = new System.Windows.Forms.Label();
            this.GVManageUsers = new System.Windows.Forms.DataGridView();
            this.notifyIconMUser = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GVManageUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeactivateUser
            // 
            this.buttonDeactivateUser.BackColor = System.Drawing.Color.Teal;
            this.buttonDeactivateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeactivateUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeactivateUser.Location = new System.Drawing.Point(1187, 497);
            this.buttonDeactivateUser.Name = "buttonDeactivateUser";
            this.buttonDeactivateUser.Size = new System.Drawing.Size(159, 49);
            this.buttonDeactivateUser.TabIndex = 14;
            this.buttonDeactivateUser.Text = "&Deactivate/Activate User";
            this.buttonDeactivateUser.UseVisualStyleBackColor = false;
            this.buttonDeactivateUser.Click += new System.EventHandler(this.buttonDeactivateUser_Click);
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.BackColor = System.Drawing.Color.Teal;
            this.buttonResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetPassword.ForeColor = System.Drawing.Color.White;
            this.buttonResetPassword.Location = new System.Drawing.Point(676, 497);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Size = new System.Drawing.Size(159, 49);
            this.buttonResetPassword.TabIndex = 13;
            this.buttonResetPassword.Text = "&Reset Password";
            this.buttonResetPassword.UseVisualStyleBackColor = false;
            this.buttonResetPassword.Click += new System.EventHandler(this.buttonResetPassword_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.Teal;
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.ForeColor = System.Drawing.Color.White;
            this.buttonAddUser.Location = new System.Drawing.Point(147, 497);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(159, 49);
            this.buttonAddUser.TabIndex = 12;
            this.buttonAddUser.Text = "&Add New User";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // labelManageUsers
            // 
            this.labelManageUsers.AutoSize = true;
            this.labelManageUsers.BackColor = System.Drawing.Color.Teal;
            this.labelManageUsers.Font = new System.Drawing.Font("Britannic Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageUsers.ForeColor = System.Drawing.Color.White;
            this.labelManageUsers.Location = new System.Drawing.Point(604, 78);
            this.labelManageUsers.Name = "labelManageUsers";
            this.labelManageUsers.Size = new System.Drawing.Size(286, 48);
            this.labelManageUsers.TabIndex = 11;
            this.labelManageUsers.Text = "Manage Users";
            // 
            // GVManageUsers
            // 
            this.GVManageUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVManageUsers.Location = new System.Drawing.Point(577, 164);
            this.GVManageUsers.Name = "GVManageUsers";
            this.GVManageUsers.Size = new System.Drawing.Size(346, 179);
            this.GVManageUsers.TabIndex = 10;
            // 
            // notifyIconMUser
            // 
            this.notifyIconMUser.Visible = true;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1457, 581);
            this.Controls.Add(this.buttonDeactivateUser);
            this.Controls.Add(this.buttonResetPassword);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.labelManageUsers);
            this.Controls.Add(this.GVManageUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.SizeChanged += new System.EventHandler(this.ManageUsers_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GVManageUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeactivateUser;
        private System.Windows.Forms.Button buttonResetPassword;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label labelManageUsers;
        private System.Windows.Forms.DataGridView GVManageUsers;
        private System.Windows.Forms.NotifyIcon notifyIconMUser;
    }
}