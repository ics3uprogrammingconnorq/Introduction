namespace AddressProgramConnorQ
{
    partial class frmAddressProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddressProgram));
            this.lblName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblName.Location = new System.Drawing.Point(36, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(203, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Connor Quinlan";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCity.Location = new System.Drawing.Point(80, 115);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(101, 31);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "Ottawa";
            this.lblCity.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCountry.Location = new System.Drawing.Point(80, 188);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(109, 31);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Canada";
            // 
            // frmAddressProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddressProgram";
            this.Text = "Address Program Connor Q";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
    }
}

