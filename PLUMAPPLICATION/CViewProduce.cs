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
    public partial class CViewProduce : Form
    {
        private readonly PLUMEntities1 pLUMEntities;
        public CViewProduce()
        {
            InitializeComponent();
            pLUMEntities = new PLUMEntities1();
        }
        public void PopulateGrid()
        {
            var produce = pLUMEntities.Farmers.Select(F => new
            {
                Id = F.Id,
                Farmer = F.FirstName + " " + F.LastName,
                Email = F.Email,
                PhoneNumber = F.PhoneNumber,
                NameOfProduce = F.NameOfProduce,
                TypeOfProduce = F.TypeOfProduce.Name,
                Quantity = F.Quantity,
                Price = F.Price,
                Location = F.Location.Name,
                DateAdded = F.DateAdded,
            })
           .ToList();
            GVPurchase.DataSource = produce;
            GVPurchase.Columns["Id"].Visible = false;
            GVPurchase.Columns["Farmer"].HeaderText = "Name Of Farmer";
            GVPurchase.Columns["Email"].HeaderText = "Email Address";
            GVPurchase.Columns["PhoneNumber"].HeaderText = "Phone Number";
            GVPurchase.Columns["NameOfProduce"].HeaderText = "Name Of Produce";
            GVPurchase.Columns["TypeOfProduce"].HeaderText = "Type Of Produce";
            GVPurchase.Columns["Quantity"].HeaderText = "Quantity";
            GVPurchase.Columns["Price"].HeaderText = "Price";
            GVPurchase.Columns["DateAdded"].HeaderText = "Date Added";
        }
        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)GVPurchase.SelectedRows[0].Cells["Id"].Value;

                var produce = pLUMEntities.Farmers.FirstOrDefault(F => F.Id == id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want To Make This Purchase?","Purchase"
                   , MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show($"Congratulations:\n\n" +
                        $"Your Transaction Has Been Completed\n\n\n" +
                        $"THANK YOU FOR YOUR BUSINESS!!\n\n" +
                        $"Come Back Again");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! Please to try again");
            }
        }

        private void CViewProduce_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! Please to try again");
            }
        }

        private void CViewProduce_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIconCV.Icon = SystemIcons.Application;
                notifyIconCV.BalloonTipText = "Your App Has Been Minimized";
                notifyIconCV.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIconCV.BalloonTipText = "Your App Has Come Back To Normal";
                notifyIconCV.ShowBalloonTip(1000);
            }
        }
    }
}
