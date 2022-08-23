namespace PLUMAPPLICATION
{
    partial class AddEditProduce
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditProduce));
            this.labelFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.MPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.labelDateAdded = new System.Windows.Forms.Label();
            this.dtpDateAdded = new System.Windows.Forms.DateTimePicker();
            this.labelLocation = new System.Windows.Forms.Label();
            this.CBLocation = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.TbQuantity = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusAddEdit = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIconAddEdit = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.Color.Black;
            this.labelFirstName.Location = new System.Drawing.Point(53, 143);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(141, 29);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbFirstName.Location = new System.Drawing.Point(12, 175);
            this.tbFirstName.Multiline = true;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(211, 20);
            this.tbFirstName.TabIndex = 5;
            this.tbFirstName.MouseLeave += new System.EventHandler(this.tbFirstName_MouseLeave);
            this.tbFirstName.MouseHover += new System.EventHandler(this.tbFirstName_MouseHover);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.labelPhoneNumber.Location = new System.Drawing.Point(23, 414);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(188, 29);
            this.labelPhoneNumber.TabIndex = 32;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // MPhoneNumber
            // 
            this.MPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPhoneNumber.Location = new System.Drawing.Point(15, 445);
            this.MPhoneNumber.Mask = "(999) 000-0000";
            this.MPhoneNumber.Name = "MPhoneNumber";
            this.MPhoneNumber.Size = new System.Drawing.Size(214, 23);
            this.MPhoneNumber.TabIndex = 33;
            this.MPhoneNumber.MouseLeave += new System.EventHandler(this.MPhoneNumber_MouseLeave);
            this.MPhoneNumber.MouseHover += new System.EventHandler(this.MPhoneNumber_MouseHover);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.Color.Black;
            this.labelLastName.Location = new System.Drawing.Point(689, 146);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(137, 29);
            this.labelLastName.TabIndex = 38;
            this.labelLastName.Text = "Last Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.ForeColor = System.Drawing.Color.Black;
            this.tbLastName.Location = new System.Drawing.Point(653, 178);
            this.tbLastName.Multiline = true;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(213, 20);
            this.tbLastName.TabIndex = 39;
            this.tbLastName.MouseLeave += new System.EventHandler(this.tbLastName_MouseLeave);
            this.tbLastName.MouseHover += new System.EventHandler(this.tbLastName_MouseHover);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(701, 275);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(79, 29);
            this.labelEmail.TabIndex = 40;
            this.labelEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(641, 307);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(213, 20);
            this.tbEmail.TabIndex = 41;
            this.tbEmail.MouseLeave += new System.EventHandler(this.tbEmail_MouseLeave);
            this.tbEmail.MouseHover += new System.EventHandler(this.tbEmail_MouseHover);
            // 
            // labelDateAdded
            // 
            this.labelDateAdded.AutoSize = true;
            this.labelDateAdded.BackColor = System.Drawing.Color.Transparent;
            this.labelDateAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateAdded.ForeColor = System.Drawing.Color.Black;
            this.labelDateAdded.Location = new System.Drawing.Point(37, 275);
            this.labelDateAdded.Name = "labelDateAdded";
            this.labelDateAdded.Size = new System.Drawing.Size(157, 29);
            this.labelDateAdded.TabIndex = 42;
            this.labelDateAdded.Text = "Date Added:";
            // 
            // dtpDateAdded
            // 
            this.dtpDateAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateAdded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAdded.Location = new System.Drawing.Point(15, 307);
            this.dtpDateAdded.Name = "dtpDateAdded";
            this.dtpDateAdded.Size = new System.Drawing.Size(208, 23);
            this.dtpDateAdded.TabIndex = 43;
            this.dtpDateAdded.Value = new System.DateTime(2022, 4, 11, 0, 0, 0, 0);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.Transparent;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.ForeColor = System.Drawing.Color.Black;
            this.labelLocation.Location = new System.Drawing.Point(700, 414);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(112, 29);
            this.labelLocation.TabIndex = 44;
            this.labelLocation.Text = "Location";
            // 
            // CBLocation
            // 
            this.CBLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLocation.FormattingEnabled = true;
            this.CBLocation.Location = new System.Drawing.Point(653, 447);
            this.CBLocation.Name = "CBLocation";
            this.CBLocation.Size = new System.Drawing.Size(213, 21);
            this.CBLocation.TabIndex = 45;
            this.CBLocation.MouseLeave += new System.EventHandler(this.CBLocation_MouseLeave);
            this.CBLocation.MouseHover += new System.EventHandler(this.CBLocation_MouseHover);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.Black;
            this.labelType.Location = new System.Drawing.Point(1202, 145);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(218, 29);
            this.labelType.TabIndex = 50;
            this.labelType.Text = "Type Of Produce:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Vegetables",
            "Fruits",
            "Poultry",
            "Meat",
            "Livestock"});
            this.comboBoxType.Location = new System.Drawing.Point(1207, 177);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(197, 21);
            this.comboBoxType.TabIndex = 51;
            this.comboBoxType.MouseLeave += new System.EventHandler(this.comboBoxType_MouseLeave);
            this.comboBoxType.MouseHover += new System.EventHandler(this.comboBoxType_MouseHover);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(1202, 244);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(228, 29);
            this.labelName.TabIndex = 52;
            this.labelName.Text = "Name Of Produce:";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(1207, 276);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(197, 20);
            this.TbName.TabIndex = 53;
            this.TbName.MouseLeave += new System.EventHandler(this.TbName_MouseLeave);
            this.TbName.MouseHover += new System.EventHandler(this.TbName_MouseHover);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.Color.Black;
            this.labelQuantity.Location = new System.Drawing.Point(1202, 353);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(115, 29);
            this.labelQuantity.TabIndex = 54;
            this.labelQuantity.Text = "Quantity:";
            // 
            // TbQuantity
            // 
            this.TbQuantity.Location = new System.Drawing.Point(1207, 385);
            this.TbQuantity.Name = "TbQuantity";
            this.TbQuantity.Size = new System.Drawing.Size(197, 20);
            this.TbQuantity.TabIndex = 55;
            this.TbQuantity.MouseLeave += new System.EventHandler(this.TbQuantity_MouseLeave);
            this.TbQuantity.MouseHover += new System.EventHandler(this.TbQuantity_MouseHover);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Black;
            this.labelPrice.Location = new System.Drawing.Point(1213, 467);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(81, 29);
            this.labelPrice.TabIndex = 56;
            this.labelPrice.Text = "Price:";
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(1207, 499);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(197, 20);
            this.TbPrice.TabIndex = 57;
            this.TbPrice.MouseLeave += new System.EventHandler(this.TbPrice_MouseLeave);
            this.TbPrice.MouseHover += new System.EventHandler(this.TbPrice_MouseHover);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Teal;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(399, 519);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(142, 36);
            this.buttonSave.TabIndex = 58;
            this.buttonSave.Text = "&SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Blue;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(894, 519);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 37);
            this.buttonCancel.TabIndex = 59;
            this.buttonCancel.Text = "&CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(418, 414);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 60;
            this.labelID.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Teal;
            this.labelTitle.Font = new System.Drawing.Font("Britannic Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(610, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 48);
            this.labelTitle.TabIndex = 61;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusAddEdit});
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1457, 22);
            this.statusStrip1.TabIndex = 62;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusAddEdit
            // 
            this.toolStripStatusAddEdit.Name = "toolStripStatusAddEdit";
            this.toolStripStatusAddEdit.Size = new System.Drawing.Size(0, 17);
            // 
            // notifyIconAddEdit
            // 
            this.notifyIconAddEdit.Visible = true;
            // 
            // AddEditProduce
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1457, 581);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.TbQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.CBLocation);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.dtpDateAdded);
            this.Controls.Add(this.labelDateAdded);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.MPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditProduce";
            this.Text = "Add Edit Produce";
            this.Load += new System.EventHandler(this.AddEditProduce_Load);
            this.SizeChanged += new System.EventHandler(this.AddEditProduce_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.MaskedTextBox MPhoneNumber;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label labelDateAdded;
        private System.Windows.Forms.DateTimePicker dtpDateAdded;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.ComboBox CBLocation;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox TbQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusAddEdit;
        private System.Windows.Forms.NotifyIcon notifyIconAddEdit;
    }
}