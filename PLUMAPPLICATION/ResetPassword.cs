using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLUMAPPLICATION
{
    public partial class ResetPassword : Form
    {
        private readonly PLUMEntities1 pLUMEntities;
        private User _user;
        public ResetPassword(User user)
        {
            InitializeComponent();
            pLUMEntities = new PLUMEntities1();
            _user = user;
        }

        private void buttonRPass_Click(object sender, EventArgs e)
        {
            try
            {
                var password = tBNewPassword.Text;
                var confirmPassword = tBCPassword.Text;
                var user = pLUMEntities.Users.FirstOrDefault(F => F.Id == _user.Id);

                if (password != confirmPassword)
                {
                    MessageBox.Show("Password do not match. Please try again!");
                }
                _user.Password = Utils.HashPassword(password);
                pLUMEntities.SaveChanges();
                MessageBox.Show("Your password was reset successfully");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error! Please try again");


            }
        }

        private void tBNewPassword_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusResetP.Text = " Enter The New Password";
        }

        private void tBNewPassword_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusResetP.Text = "";
        }

        private void tBCPassword_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusResetP.Text = "Confirm The Password You Entered";
        }

        private void tBCPassword_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusResetP.Text = "";
        }

        private void ResetPassword_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIconRPass.Icon = SystemIcons.Application;
                notifyIconRPass.BalloonTipText = "Your App Has Been Minimized";
                notifyIconRPass.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIconRPass.BalloonTipText = "Your App Has Come Back To Normal";
                notifyIconRPass.ShowBalloonTip(1000);
            }
        }
    }
}
