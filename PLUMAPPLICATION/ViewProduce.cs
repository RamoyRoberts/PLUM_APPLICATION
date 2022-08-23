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
    public partial class ViewProduce : Form
    {
        private readonly PLUMEntities1 pLUMEntities;
        public ViewProduce()
        {
            InitializeComponent();
            pLUMEntities = new PLUMEntities1();
        }
        private void buttonAddProduce_Click(object sender, EventArgs e)
        {
            var addEditProduce = new AddEditProduce(this);
            addEditProduce.ShowDialog();
            addEditProduce.MdiParent = this.MdiParent;
            MessageBox.Show("Your Information Has Been Added!");


        }
        private void buttonEditProduce_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)GVProduce.SelectedRows[0].Cells["Id"].Value;

                var produce = pLUMEntities.Farmers.FirstOrDefault(F => F.Id == id);

                var addEditProduce = new AddEditProduce(produce, this);
                addEditProduce.ShowDialog();
                addEditProduce.MdiParent = this.MdiParent;
                MessageBox.Show("Your Changes Has Been Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! Please to try again");
            }
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
            GVProduce.DataSource = produce;
            GVProduce.Columns["Id"].Visible = false;
            GVProduce.Columns["Farmer"].HeaderText = "Name Of Farmer";
            GVProduce.Columns["Email"].HeaderText = "Email Address";
            GVProduce.Columns["PhoneNumber"].HeaderText = "Phone Number";
            GVProduce.Columns["NameOfProduce"].HeaderText = "Name Of Produce";
            GVProduce.Columns["TypeOfProduce"].HeaderText = "Type Of Produce";
            GVProduce.Columns["Quantity"].HeaderText = "Quantity";
            GVProduce.Columns["Price"].HeaderText = "Price";
            GVProduce.Columns["DateAdded"].HeaderText = "Date Added";
        }
        private void buttonDeleteProduce_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)GVProduce.SelectedRows[0].Cells["Id"].Value;

                var produce = pLUMEntities.Farmers.FirstOrDefault(F => F.Id == id);

                DialogResult dr = MessageBox.Show("Delete!! Are You Sure?",
                    "Delete", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    pLUMEntities.Farmers.Remove(produce);
                    pLUMEntities.SaveChanges();

                    PopulateGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong! Please to try again");
            }
        }
        private void ViewProduce_Load(object sender, EventArgs e)
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

        private void ViewProduce_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIconV.Icon = SystemIcons.Application;
                notifyIconV.BalloonTipText = "Your App Has Been Minimized";
                notifyIconV.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIconV.BalloonTipText = "Your App Has Come Back To Normal";
                notifyIconV.ShowBalloonTip(1000);
            }
        }
    }
}
    

