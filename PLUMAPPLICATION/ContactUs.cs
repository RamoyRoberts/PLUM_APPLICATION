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
    public partial class ContactUs : Form
    {
        private readonly PLUMEntities1 pLUMEntities;
        public ContactUs()
        {
            InitializeComponent();
            pLUMEntities = new PLUMEntities1();
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)

        {
            try
            {
                string Name = TBName.Text;
                string Email = TBEmail.Text;
                string YourMessage = TBYourMessage.Text;

                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(Name))
                {
                    isValid = false;
                    errorMessage = "Error: Your name is missing! Please to enter the missing data\n\n";
                }

                if (string.IsNullOrWhiteSpace(Email))
                {
                    isValid = false;
                    errorMessage = "Error: Your email is missing! Please to enter the missing data\n\n";
                }
                if (string.IsNullOrWhiteSpace(YourMessage))
                {
                    isValid = false;
                    errorMessage = "Error: The message field is empty! Please to enter the missing data\n\n";
                }

                if (isValid)
                {
                    var ContactRecord = new ClientInfo();
                    ContactRecord.Name = Name;
                    ContactRecord.Email = Email;
                    ContactRecord.YourMessage = YourMessage;

                    pLUMEntities.ClientInfoes.Add(ContactRecord);
                    pLUMEntities.SaveChanges();



                    MessageBox.Show($"Hi, {Name} your message has been sent.\n\n" +
                        $"Please to check your {Email} for a respond from us.\n\n\n" +
                        $"Sincerly P.L.U.M Inc.");
                }

                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var homepage = new HomePage();
            homepage.Show();
        }

        private void TBName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusAboutUs.Text = "Please To Enter Your Full Name";
        }

        private void TBName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusAboutUs.Text = "";
        }

        private void TBEmail_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusAboutUs.Text = "Please To Enter Your Email Address";
        }

        private void TBEmail_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusAboutUs.Text = "";
        }

        private void TBYourMessage_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusAboutUs.Text = "Please To Type The Message You Want To Send";
        }

        private void TBYourMessage_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusAboutUs.Text = "";
        }

        private void ContactUs_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIconContactUs.Icon = SystemIcons.Application;
                notifyIconContactUs.BalloonTipText = "Your App Has Been Minimized";
                notifyIconContactUs.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIconContactUs.BalloonTipText = "Your App Has Come Back To Normal";
                notifyIconContactUs.ShowBalloonTip(1000);
            }
        }
    }
}