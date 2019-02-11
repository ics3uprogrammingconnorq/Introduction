namespace PerAreaVolConnorQ
{
    partial class frmPerAreaVol
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
            this.btnPerOfRectangle = new System.Windows.Forms.Button();
            this.btnAreaOfCircle = new System.Windows.Forms.Button();
            this.btnVolumeOfSphere = new System.Windows.Forms.Button();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPerOfRectangle
            // 
            this.btnPerOfRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPerOfRectangle.Location = new System.Drawing.Point(12, 72);
            this.btnPerOfRectangle.Name = "btnPerOfRectangle";
            this.btnPerOfRectangle.Size = new System.Drawing.Size(242, 126);
            this.btnPerOfRectangle.TabIndex = 0;
            this.btnPerOfRectangle.Text = "A rectangle has side lenghs of 7cm and 9cm. What is the perimeter of the rectangl" +
    "e?";
            this.btnPerOfRectangle.UseVisualStyleBackColor = true;
            this.btnPerOfRectangle.Click += new System.EventHandler(this.btnPerOfRectangle_Click);
            // 
            // btnAreaOfCircle
            // 
            this.btnAreaOfCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAreaOfCircle.Location = new System.Drawing.Point(12, 234);
            this.btnAreaOfCircle.Name = "btnAreaOfCircle";
            this.btnAreaOfCircle.Size = new System.Drawing.Size(242, 130);
            this.btnAreaOfCircle.TabIndex = 1;
            this.btnAreaOfCircle.Text = "A circle has a diameter of 9cm. What is the area of the circle?";
            this.btnAreaOfCircle.UseVisualStyleBackColor = true;
            this.btnAreaOfCircle.Click += new System.EventHandler(this.btnAreaOfCircle_Click);
            // 
            // btnVolumeOfSphere
            // 
            this.btnVolumeOfSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVolumeOfSphere.Location = new System.Drawing.Point(12, 397);
            this.btnVolumeOfSphere.Name = "btnVolumeOfSphere";
            this.btnVolumeOfSphere.Size = new System.Drawing.Size(242, 130);
            this.btnVolumeOfSphere.TabIndex = 2;
            this.btnVolumeOfSphere.Text = "Thr radius of a sphere is 6cm. What is the volume of the sphere.";
            this.btnVolumeOfSphere.UseVisualStyleBackColor = true;
            this.btnVolumeOfSphere.Click += new System.EventHandler(this.btnVolumeOfSphere_Click);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAnswer1.Location = new System.Drawing.Point(727, 130);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(18, 20);
            this.lblAnswer1.TabIndex = 3;
            this.lblAnswer1.Text = "?";
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAnswer2.Location = new System.Drawing.Point(727, 294);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(18, 20);
            this.lblAnswer2.TabIndex = 4;
            this.lblAnswer2.Text = "?";
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAnswer3.Location = new System.Drawing.Point(727, 456);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(18, 20);
            this.lblAnswer3.TabIndex = 5;
            this.lblAnswer3.Text = "?";
            // 
            // frmPerAreaVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 592);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.btnVolumeOfSphere);
            this.Controls.Add(this.btnAreaOfCircle);
            this.Controls.Add(this.btnPerOfRectangle);
            this.Name = "frmPerAreaVol";
            this.Text = "Perimeter, Area, Volume by Connor Quinlan";
            this.Load += new System.EventHandler(this.PerAreaVolForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerOfRectangle;
        private System.Windows.Forms.Button btnAreaOfCircle;
        private System.Windows.Forms.Button btnVolumeOfSphere;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
    }
}

