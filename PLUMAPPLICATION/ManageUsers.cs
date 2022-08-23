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
    public partial class ManageUsers : Form
    {
        private readonly PLUMEntities1 pLUMEntities;
        public ManageUsers()
        {
            InitializeComponent();
            pLUMEntities = new PLUMEntities1();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var addUser = new AddUser(this);
            addUser.ShowDialog();
            addUser.MdiParent = this.MdiParent;
        }
        private void buttonResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
              
                var id = (int)GVManageUsers.SelectedRows[0].Cells["Id"].Value;

                var RPassword = pLUMEntities.Users.FirstOrDefault(F => F.Id == id);

                var HashedPassword = Utils.DefaultHashedPassword();
                RPassword.Password = HashedPassword;
                pLUMEntities.SaveChanges();

                MessageBox.Show($"{RPassword.Username}'s Password has been reset!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong! Please to try again");
            }
        }

        private void buttonDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)GVManageUsers.SelectedRows[0].Cells["Id"].Value;

                var user = pLUMEntities.Users.FirstOrDefault(F => F.Id == id);
                user.isActive = user.isActive == true ? false : true;
                pLUMEntities.SaveChanges();

                MessageBox.Show($"{user.Username}'s active status has changed!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! Please to try again");
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var users = pLUMEntities.Users
                .Select(F => new
                {
                    F.Id,
                    F.Username,
                    F.UserRoles.FirstOrDefault().Role.Name,
                    F.isActive
                })
                .ToList();
            GVManageUsers.DataSource = users;
            GVManageUsers.Columns["Name"].HeaderText = "Name Of Role";
            GVManageUsers.Columns["isActive"].HeaderText = "Active";
            GVManageUsers.Columns["Id"].Visible = false;
        }

        private void ManageUsers_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIconMUser.Icon = SystemIcons.Application;
                notifyIconMUser.BalloonTipText = "Your App Has Been Minimized";
                notifyIconMUser.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIconMUser.BalloonTipText = "Your App Has Come Back To Normal";
                notifyIconMUser.ShowBalloonTip(1000);
            }
        }
    }
}
