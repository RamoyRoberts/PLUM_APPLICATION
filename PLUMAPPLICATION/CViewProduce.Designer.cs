namespace PLUMAPPLICATION
{
    partial class CViewProduce
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
            this.notifyIconCV = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelViewProduce = new System.Windows.Forms.Label();
            this.GVPurchase = new System.Windows.Forms.DataGridView();
            this.buttonPurchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIconCV
            // 
            this.notifyIconCV.Visible = true;
            // 
            // labelViewProduce
            // 
            this.labelViewProduce.AutoSize = true;
            this.labelViewProduce.BackColor = System.Drawing.Color.Teal;
            this.labelViewProduce.Font = new System.Drawing.Font("Britannic Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewProduce.ForeColor = System.Drawing.Color.White;
            this.labelViewProduce.Location = new System.Drawing.Point(60, 22);
            this.labelViewProduce.Name = "labelViewProduce";
            this.labelViewProduce.Size = new System.Drawing.Size(273, 48);
            this.labelViewProduce.TabIndex = 7;
            this.labelViewProduce.Text = "View Produce";
            // 
            // GVPurchase
            // 
            this.GVPurchase.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GVPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVPurchase.Location = new System.Drawing.Point(224, 86);
            this.GVPurchase.Name = "GVPurchase";
            this.GVPurchase.Size = new System.Drawing.Size(943, 405);
            this.GVPurchase.TabIndex = 8;
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.BackColor = System.Drawing.Color.Teal;
            this.buttonPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchase.ForeColor = System.Drawing.Color.White;
            this.buttonPurchase.Location = new System.Drawing.Point(637, 508);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(164, 51);
            this.buttonPurchase.TabIndex = 9;
            this.buttonPurchase.Text = "&Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = false;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // CViewProduce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 581);
            this.Controls.Add(this.buttonPurchase);
            this.Controls.Add(this.GVPurchase);
            this.Controls.Add(this.labelViewProduce);
            this.Name = "CViewProduce";
            this.Text = "CViewProduce";
            this.Load += new System.EventHandler(this.CViewProduce_Load);
            this.SizeChanged += new System.EventHandler(this.CViewProduce_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GVPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconCV;
        private System.Windows.Forms.Label labelViewProduce;
        private System.Windows.Forms.DataGridView GVPurchase;
        private System.Windows.Forms.Button buttonPurchase;
    }
}