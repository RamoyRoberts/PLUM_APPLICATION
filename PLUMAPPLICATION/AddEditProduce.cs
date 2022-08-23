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
    public partial class AddEditProduce : Form
    {
        private bool isEditMode;
        private ViewProduce _viewProduce;
        private readonly PLUMEntities1 pLUMEntities;

        public AddEditProduce(ViewProduce viewProduce = null)
        {
            InitializeComponent();
            pLUMEntities = new PLUMEntities1();
            isEditMode = false;
            labelTitle.Text = "Add Produce";
            this.Text = "Add Produce";
            _viewProduce = viewProduce;

        }
        public AddEditProduce(Farmer producetoEdit, ViewProduce viewProduce)
        {
            InitializeComponent();
            isEditMode = true;
            labelTitle.Text = "Edit Produce";
            this.Text = "Edit Produce";
            _viewProduce = viewProduce;

            if (producetoEdit == null)
            {
                MessageBox.Show("Please ensure that you select a valid recort to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                pLUMEntities = new PLUMEntities1();
                PopulateFields(producetoEdit);
            }
        }
        private void PopulateFields(Farmer producetoEdit)
        {
            tbFirstName.Text = producetoEdit.FirstName;
            tbLastName.Text = producetoEdit.LastName;
            tbEmail.Text = producetoEdit.Email;
            MPhoneNumber.Text = producetoEdit.PhoneNumber;
            TbName.Text = producetoEdit.NameOfProduce;
            comboBoxType.Text = producetoEdit.TypeOfProduce.ToString();
            TbQuantity.Text = producetoEdit.Quantity;
            TbPrice.Text = producetoEdit.Price.ToString();
            CBLocation.Text = producetoEdit.Location.ToString();
            dtpDateAdded.Value = (DateTime)producetoEdit.DateAdded;
            labelID.Text = producetoEdit.Id.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string FirstName = tbFirstName.Text;
                string LastName = tbLastName.Text;
                string Email = tbEmail.Text;
                string PhoneNumber = MPhoneNumber.Text;
                string NameOfProduce = TbName.Text;
                var TypeOfProduceId = comboBoxType.Text;
                string Quantity = TbQuantity.Text;
                decimal Price = Convert.ToDecimal(TbPrice.Text);
                var LocationId = CBLocation.Text;
                var DateAdded = dtpDateAdded.Value;

                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(FirstName))
                {
                    isValid = false;
                    errorMessage += "Error: Your first name is missing! Please to enter the missing data\n\n";
                }

                if (string.IsNullOrWhiteSpace(LastName))
                {
                    isValid = false;
                    errorMessage += "Error: Your last name is missing! Please to enter the missing data\n\n";
                }
                if (string.IsNullOrWhiteSpace(TypeOfProduceId))
                {
                    isValid = false;
                    errorMessage += "Error: The type of produce has not been selected! Please to enter the missing data\n\n";
                }
                if (string.IsNullOrWhiteSpace(NameOfProduce))
                {
                    isValid = false;
                    errorMessage += "Error: The name of the produce is missing! Please to enter the missing data\n\n";
                }
                if (string.IsNullOrWhiteSpace(Email))
                {
                    isValid = false;
                    errorMessage += "Error: Your email is missing! Please to enter the missing data\n\n";
                }
                if (string.IsNullOrWhiteSpace(PhoneNumber))
                {
                    isValid = false;
                    errorMessage += "Error: Your phone number is missing! Please to enter the missing data\n\n";
                }

                if (string.IsNullOrWhiteSpace(Quantity))
                {
                    isValid = false;
                    errorMessage += "Error: The Quantity field is empty! Please to enter the missing data\n\n";
                }

                if (string.IsNullOrWhiteSpace(LocationId))
                {
                    isValid = false;
                    errorMessage += "Error: The Location field has not been selected! Please to enter the missing data\n\n";
                }

                if (isValid)
                {
                    var farmerp = new Farmer();

                    if (isEditMode)
                    {
                        var id = int.Parse(labelID.Text);
                        farmerp = pLUMEntities.Farmers.FirstOrDefault(F => F.Id == id);
                    }

                    farmerp.FirstName = FirstName;
                    farmerp.LastName = LastName;
                    farmerp.Email = Email;
                    farmerp.PhoneNumber = PhoneNumber;
                    farmerp.NameOfProduce = NameOfProduce;
                    farmerp.TypeOfProduceId = (int)comboBoxType.SelectedValue;
                    farmerp.Quantity = Quantity;
                    farmerp.Price = (decimal)Price;
                    farmerp.LocationId = (int)CBLocation.SelectedValue;
                    farmerp.DateAdded = DateAdded;

                    if (!isEditMode)
                        pLUMEntities.Farmers.Add(farmerp);

                }
                pLUMEntities.SaveChanges();
                _viewProduce.PopulateGrid();

                MessageBox.Show($"Congrats! {FirstName} {LastName}\n\n" +
                $"Your Information Has Been Added Successfully.\n\n\n" +
                $"THANK YOU FOR YOUR BUSINESS\n\n\n" +
                $"Sincerly: P.L.U.M.");
                Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong! Please to try again");
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AddEditProduce_Load(object sender, EventArgs e)
        {
            var ProdType = pLUMEntities.TypeOfProduces
                .Select(F => new { Id = F.Id, Name = F.Name })
                .ToList();
            comboBoxType.ValueMember = "Id";
            comboBoxType.DisplayMember = "Name";
            comboBoxType.DataSource = ProdType;

            var FarmLoc = pLUMEntities.Locations
                .Select(F => new { Id = F.Id, Name = F.Name })
                .ToList();
            CBLocation.ValueMember = "Id";
            CBLocation.DisplayMember = "Name";
            CBLocation.DataSource = FarmLoc;
        }

        private void tbFirstName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "Enter You First Name";
        }

        private void tbFirstName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "";
        }

        private void tbLastName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "Enter Your Last Name";
        }

        private void tbLastName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "";
        }

        private void tbEmail_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "Enter Your Email Address";
        }

        private void tbEmail_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "";
        }

        private void CBLocation_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "Select Your Location";
        }

        private void CBLocation_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "";
        }

        private void MPhoneNumber_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "Enter Your Phone Number";
        }

        private void MPhoneNumber_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "";
        }

        private void TbName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "Enter The Name Of Your Produce";
        }

        private void TbName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "";
        }

        private void TbQuantity_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "Enter The Quantity Of The Produce";
        }

        private void TbQuantity_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "";
        }

        private void TbPrice_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "Enter The Price Of Your Produce";

        }

        private void TbPrice_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "";
        }

        private void comboBoxType_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "Select The Type Of Produce";
        }

        private void comboBoxType_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusAddEdit.Text = "";
        }

        private void AddEditProduce_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIconAddEdit.Icon = SystemIcons.Application;
                notifyIconAddEdit.BalloonTipText = "Your App Has Been Minimized";
                notifyIconAddEdit.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIconAddEdit.BalloonTipText = "Your App Has Come Back To Normal";
                notifyIconAddEdit.ShowBalloonTip(1000);
            }
        }
    }
}

