namespace PLUMAPPLICATION
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.labelPassword = new System.Windows.Forms.Label();
            this.tBNewPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.tBCPassword = new System.Windows.Forms.TextBox();
            this.buttonRPass = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusResetP = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIconRPass = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(603, 103);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(257, 29);
            this.labelPassword.TabIndex = 15;
            this.labelPassword.Text = "Enter New Password";
            // 
            // tBNewPassword
            // 
            this.tBNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNewPassword.ForeColor = System.Drawing.Color.Black;
            this.tBNewPassword.Location = new System.Drawing.Point(578, 135);
            this.tBNewPassword.Multiline = true;
            this.tBNewPassword.Name = "tBNewPassword";
            this.tBNewPassword.PasswordChar = '*';
            this.tBNewPassword.Size = new System.Drawing.Size(294, 35);
            this.tBNewPassword.TabIndex = 16;
            this.tBNewPassword.MouseLeave += new System.EventHandler(this.tBNewPassword_MouseLeave);
            this.tBNewPassword.MouseHover += new System.EventHandler(this.tBNewPassword_MouseHover);
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.labelConfirmPassword.Location = new System.Drawing.Point(614, 273);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(226, 29);
            this.labelConfirmPassword.TabIndex = 17;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // tBCPassword
            // 
            this.tBCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCPassword.ForeColor = System.Drawing.Color.Black;
            this.tBCPassword.Location = new System.Drawing.Point(578, 305);
            this.tBCPassword.Multiline = true;
            this.tBCPassword.Name = "tBCPassword";
            this.tBCPassword.PasswordChar = '*';
            this.tBCPassword.Size = new System.Drawing.Size(294, 37);
            this.tBCPassword.TabIndex = 18;
            this.tBCPassword.MouseLeave += new System.EventHandler(this.tBCPassword_MouseLeave);
            this.tBCPassword.MouseHover += new System.EventHandler(this.tBCPassword_MouseHover);
            // 
            // buttonRPass
            // 
            this.buttonRPass.BackColor = System.Drawing.Color.Teal;
            this.buttonRPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRPass.ForeColor = System.Drawing.Color.White;
            this.buttonRPass.Location = new System.Drawing.Point(652, 410);
            this.buttonRPass.Name = "buttonRPass";
            this.buttonRPass.Size = new System.Drawing.Size(156, 45);
            this.buttonRPass.TabIndex = 60;
            this.buttonRPass.Text = "&Reset Password";
            this.buttonRPass.UseVisualStyleBackColor = false;
            this.buttonRPass.Click += new System.EventHandler(this.buttonRPass_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusResetP});
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1457, 22);
            this.statusStrip1.TabIndex = 61;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusResetP
            // 
            this.toolStripStatusResetP.Name = "toolStripStatusResetP";
            this.toolStripStatusResetP.Size = new System.Drawing.Size(0, 17);
            // 
            // notifyIconRPass
            // 
            this.notifyIconRPass.Visible = true;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1457, 581);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonRPass);
            this.Controls.Add(this.tBCPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.tBNewPassword);
            this.Controls.Add(this.labelPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPassword";
            this.Text = "Reset Password";
            this.SizeChanged += new System.EventHandler(this.ResetPassword_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox tBNewPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox tBCPassword;
        private System.Windows.Forms.Button buttonRPass;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusResetP;
        private System.Windows.Forms.NotifyIcon notifyIconRPass;
    }
}