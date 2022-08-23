using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLUMAPPLICATION
{
    public partial class Login : Form
    {
        private readonly PLUMEntities1 pLUMEntities;

        public Login()
        {
            InitializeComponent();
             pLUMEntities = new PLUMEntities1();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                var UserName = tbUsername.Text.Trim();
                var PassWord = tbPassword.Text;

                //var HashedPassword = Utils.HashPassword(PassWord);

                var user = pLUMEntities.Users.FirstOrDefault(f=> f.Username==UserName && f.Password==PassWord && f.isActive==true);

                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                   // var role = user.UserRoles.FirstOrDefault();
                   // var roleShortName = role.Role.ShortName;
                    var homePage = new HomePage(this, user);
                    homePage.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong please to try again");
            }

        }

        private void tbUsername_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusSignIn.Text = "Enter Your Username";
        }

        private void tbUsername_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusSignIn.Text = "";
        }

        private void tbPassword_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusSignIn.Text = "Enter Your Password";
        }

        private void tbPassword_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusSignIn.Text = "";
        }

        private void Login_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIconSignIn.Icon = SystemIcons.Application;
                notifyIconSignIn.BalloonTipText = "Your App Has Been Minimized";
                notifyIconSignIn.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIconSignIn.BalloonTipText = "Your App Has Come Back To Normal";
                notifyIconSignIn.ShowBalloonTip(1000);
            }
        }
    }
}
