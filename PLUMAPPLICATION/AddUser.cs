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
    public partial class AddUser : Form
    {
        private readonly PLUMEntities1 pLUMEntities;
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers manageUsers)
        {
            InitializeComponent();
            pLUMEntities = new PLUMEntities1();
            _manageUsers = manageUsers;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = pLUMEntities.Roles.ToList();
            CBRole.DataSource = roles;
            CBRole.ValueMember = "Id";
            CBRole.DisplayMember = "Name";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tBUsername.Text;
                var roleId = (int)CBRole.SelectedValue;
                var password = Utils.DefaultHashedPassword();
                var user = new User
                {
                    Username = username,
                    Password = password,
                    isActive = true
                };
                pLUMEntities.Users.Add(user);
                pLUMEntities.SaveChanges();

                var userid = user.Id;
                var userRole = new UserRole
                {
                    RoleId = roleId,
                    UserId = userid
                };
                pLUMEntities.UserRoles.Add(userRole);
                pLUMEntities.SaveChanges();
                MessageBox.Show("A new user has been added successfully");
                _manageUsers.PopulateGrid();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Something went wrong. Please try again");

            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddUser_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIconAddUser.Icon = SystemIcons.Application;
                notifyIconAddUser.BalloonTipText = "Your App Has Been Minimized";
                notifyIconAddUser.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIconAddUser.BalloonTipText = "Your App Has Come Back To Normal";
                notifyIconAddUser.ShowBalloonTip(1000);
            }
        }
    }
}
