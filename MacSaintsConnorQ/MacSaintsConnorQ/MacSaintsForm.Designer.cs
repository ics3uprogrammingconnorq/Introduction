namespace MacSaintsConnorQ
{
    partial class frmMacSaints
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
            this.mnuProgram = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblMac = new System.Windows.Forms.Label();
            this.lblSaints = new System.Windows.Forms.Label();
            this.mnuProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuProgram
            // 
            this.mnuProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.mnuProgram.Location = new System.Drawing.Point(0, 0);
            this.mnuProgram.Name = "mnuProgram";
            this.mnuProgram.Size = new System.Drawing.Size(284, 24);
            this.mnuProgram.TabIndex = 0;
            this.mnuProgram.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblMac
            // 
            this.lblMac.AutoSize = true;
            this.lblMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblMac.ForeColor = System.Drawing.Color.White;
            this.lblMac.Location = new System.Drawing.Point(76, 100);
            this.lblMac.Name = "lblMac";
            this.lblMac.Size = new System.Drawing.Size(126, 26);
            this.lblMac.TabIndex = 2;
            this.lblMac.Text = "Immaculata";
            // 
            // lblSaints
            // 
            this.lblSaints.AutoSize = true;
            this.lblSaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSaints.ForeColor = System.Drawing.Color.White;
            this.lblSaints.Location = new System.Drawing.Point(100, 154);
            this.lblSaints.Name = "lblSaints";
            this.lblSaints.Size = new System.Drawing.Size(73, 26);
            this.lblSaints.TabIndex = 3;
            this.lblSaints.Text = "Saints";
            this.lblSaints.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmMacSaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblSaints);
            this.Controls.Add(this.lblMac);
            this.Controls.Add(this.mnuProgram);
            this.MainMenuStrip = this.mnuProgram;
            this.Name = "frmMacSaints";
            this.Text = "Mac Saints App";
            this.mnuProgram.ResumeLayout(false);
            this.mnuProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProgram;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblMac;
        private System.Windows.Forms.Label lblSaints;
    }
}

