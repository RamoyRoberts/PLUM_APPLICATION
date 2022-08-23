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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                notifyIconAboutUs.Icon = SystemIcons.Application;
                notifyIconAboutUs.BalloonTipText = "Your App Has Been Minimized";
                notifyIconAboutUs.ShowBalloonTip(1000);
            }
            else if(this.WindowState == FormWindowState.Normal)
            {
                notifyIconAboutUs.BalloonTipText = "Your App Has Come Back To Normal";
                notifyIconAboutUs.ShowBalloonTip(1000);
            }
        }
    }
}
