namespace PLUMAPPLICATION
{
    partial class ViewProduce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProduce));
            this.GVProduce = new System.Windows.Forms.DataGridView();
            this.labelViewProduce = new System.Windows.Forms.Label();
            this.buttonAddProduce = new System.Windows.Forms.Button();
            this.buttonEditProduce = new System.Windows.Forms.Button();
            this.buttonDeleteProduce = new System.Windows.Forms.Button();
            this.notifyIconV = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GVProduce)).BeginInit();
            this.SuspendLayout();
            // 
            // GVProduce
            // 
            this.GVProduce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVProduce.Location = new System.Drawing.Point(25, 88);
            this.GVProduce.Name = "GVProduce";
            this.GVProduce.Size = new System.Drawing.Size(1401, 374);
            this.GVProduce.TabIndex = 0;
            // 
            // labelViewProduce
            // 
            this.labelViewProduce.AutoSize = true;
            this.labelViewProduce.BackColor = System.Drawing.Color.Teal;
            this.labelViewProduce.Font = new System.Drawing.Font("Britannic Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewProduce.ForeColor = System.Drawing.Color.White;
            this.labelViewProduce.Location = new System.Drawing.Point(99, 23);
            this.labelViewProduce.Name = "labelViewProduce";
            this.labelViewProduce.Size = new System.Drawing.Size(273, 48);
            this.labelViewProduce.TabIndex = 6;
            this.labelViewProduce.Text = "View Produce";
            // 
            // buttonAddProduce
            // 
            this.buttonAddProduce.BackColor = System.Drawing.Color.Teal;
            this.buttonAddProduce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduce.ForeColor = System.Drawing.Color.White;
            this.buttonAddProduce.Location = new System.Drawing.Point(25, 489);
            this.buttonAddProduce.Name = "buttonAddProduce";
            this.buttonAddProduce.Size = new System.Drawing.Size(159, 49);
            this.buttonAddProduce.TabIndex = 7;
            this.buttonAddProduce.Text = "&Add Produce";
            this.buttonAddProduce.UseVisualStyleBackColor = false;
            this.buttonAddProduce.Click += new System.EventHandler(this.buttonAddProduce_Click);
            // 
            // buttonEditProduce
            // 
            this.buttonEditProduce.BackColor = System.Drawing.Color.Teal;
            this.buttonEditProduce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditProduce.ForeColor = System.Drawing.Color.White;
            this.buttonEditProduce.Location = new System.Drawing.Point(670, 489);
            this.buttonEditProduce.Name = "buttonEditProduce";
            this.buttonEditProduce.Size = new System.Drawing.Size(159, 49);
            this.buttonEditProduce.TabIndex = 8;
            this.buttonEditProduce.Text = "&Edit Produce";
            this.buttonEditProduce.UseVisualStyleBackColor = false;
            this.buttonEditProduce.Click += new System.EventHandler(this.buttonEditProduce_Click);
            // 
            // buttonDeleteProduce
            // 
            this.buttonDeleteProduce.BackColor = System.Drawing.Color.Teal;
            this.buttonDeleteProduce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteProduce.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteProduce.Location = new System.Drawing.Point(1267, 489);
            this.buttonDeleteProduce.Name = "buttonDeleteProduce";
            this.buttonDeleteProduce.Size = new System.Drawing.Size(159, 49);
            this.buttonDeleteProduce.TabIndex = 9;
            this.buttonDeleteProduce.Text = "&Delete Produce";
            this.buttonDeleteProduce.UseVisualStyleBackColor = false;
            this.buttonDeleteProduce.Click += new System.EventHandler(this.buttonDeleteProduce_Click);
            // 
            // notifyIconV
            // 
            this.notifyIconV.Visible = true;
            // 
            // ViewProduce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1457, 581);
            this.Controls.Add(this.buttonDeleteProduce);
            this.Controls.Add(this.buttonEditProduce);
            this.Controls.Add(this.buttonAddProduce);
            this.Controls.Add(this.labelViewProduce);
            this.Controls.Add(this.GVProduce);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewProduce";
            this.Tag = "";
            this.Text = "View Produce";
            this.Load += new System.EventHandler(this.ViewProduce_Load);
            this.SizeChanged += new System.EventHandler(this.ViewProduce_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GVProduce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GVProduce;
        private System.Windows.Forms.Label labelViewProduce;
        private System.Windows.Forms.Button buttonAddProduce;
        private System.Windows.Forms.Button buttonEditProduce;
        private System.Windows.Forms.Button buttonDeleteProduce;
        private System.Windows.Forms.NotifyIcon notifyIconV;
    }
}