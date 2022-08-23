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
    public partial class HomePage : Form
    {
        private Login _login;
        public string _roleName;
        public User _user;

        public HomePage()
        {
            InitializeComponent();
        }
        public HomePage(Login login, User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _roleName = user.UserRoles.FirstOrDefault().Role.ShortName;
        }


        private void AboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var aboutus = new AboutUs();
            aboutus.ShowDialog();
            aboutus.MdiParent = this;
        }

        private void ContactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var contactus = new ContactUs();
            contactus.ShowDialog();
            contactus.MdiParent = this;

        }

        private void viewProduceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewProduce = new ViewProduce();
            viewProduce.ShowDialog();
            viewProduce.MdiParent = this;
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewProduce = new ManageUsers();
            viewProduce.ShowDialog();
            viewProduce.MdiParent = this;
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            if (_user.Password == Utils.DefaultHashedPassword())
            {
                var resetPassword = new ResetPassword(_user);
                resetPassword.ShowDialog();
            }

            var username = _user.Username;
            logintext.Text = $"Logged In As: {username}";
            if (_roleName != "Admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
                viewProduceToolStripMenuItem.Visible = false;
               
            }
        }

            private void HomePage_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIconHome.Icon = SystemIcons.Application;
                notifyIconHome.BalloonTipText = "Your App Has Been Minimized";
                notifyIconHome.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIconHome.BalloonTipText = "Your App Has Come Back To Normal";
                notifyIconHome.ShowBalloonTip(1000);
            }
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewProduce = new CViewProduce();
            viewProduce.ShowDialog();
            viewProduce.MdiParent = this;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var log = new Login();
            log.Show();
            Hide();
        }
    }
}
