namespace HelloWorldIntConnorQ
{
    partial class frmHelloWorldInt
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
            this.lblGreetings = new System.Windows.Forms.Label();
            this.grbLanguages = new System.Windows.Forms.GroupBox();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.radGerman = new System.Windows.Forms.RadioButton();
            this.radRussian = new System.Windows.Forms.RadioButton();
            this.mnuExit = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grbLanguages.SuspendLayout();
            this.mnuExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblGreetings.Location = new System.Drawing.Point(40, 60);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(70, 26);
            this.lblGreetings.TabIndex = 0;
            this.lblGreetings.Text = "label1";
            this.lblGreetings.Click += new System.EventHandler(this.lblGreetings_Click);
            // 
            // grbLanguages
            // 
            this.grbLanguages.Controls.Add(this.radRussian);
            this.grbLanguages.Controls.Add(this.radGerman);
            this.grbLanguages.Controls.Add(this.radFrench);
            this.grbLanguages.Controls.Add(this.radEnglish);
            this.grbLanguages.Location = new System.Drawing.Point(39, 127);
            this.grbLanguages.Name = "grbLanguages";
            this.grbLanguages.Size = new System.Drawing.Size(198, 141);
            this.grbLanguages.TabIndex = 1;
            this.grbLanguages.TabStop = false;
            this.grbLanguages.Text = "Languages";
            this.grbLanguages.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(6, 19);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Location = new System.Drawing.Point(6, 63);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(58, 17);
            this.radFrench.TabIndex = 1;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "French";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.radFrench_CheckedChanged);
            // 
            // radGerman
            // 
            this.radGerman.AutoSize = true;
            this.radGerman.Location = new System.Drawing.Point(101, 19);
            this.radGerman.Name = "radGerman";
            this.radGerman.Size = new System.Drawing.Size(62, 17);
            this.radGerman.TabIndex = 2;
            this.radGerman.TabStop = true;
            this.radGerman.Text = "German";
            this.radGerman.UseVisualStyleBackColor = true;
            this.radGerman.CheckedChanged += new System.EventHandler(this.radGerman_CheckedChanged);
            // 
            // radRussian
            // 
            this.radRussian.AutoSize = true;
            this.radRussian.Location = new System.Drawing.Point(100, 63);
            this.radRussian.Name = "radRussian";
            this.radRussian.Size = new System.Drawing.Size(63, 17);
            this.radRussian.TabIndex = 3;
            this.radRussian.TabStop = true;
            this.radRussian.Text = "Russian";
            this.radRussian.UseVisualStyleBackColor = true;
            this.radRussian.CheckedChanged += new System.EventHandler(this.radRussian_CheckedChanged);
            // 
            // mnuExit
            // 
            this.mnuExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.mnuExit.Location = new System.Drawing.Point(0, 0);
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(289, 24);
            this.mnuExit.TabIndex = 2;
            this.mnuExit.Text = "Program";
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
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmHelloWorldInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 341);
            this.Controls.Add(this.grbLanguages);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.mnuExit);
            this.MainMenuStrip = this.mnuExit;
            this.Name = "frmHelloWorldInt";
            this.Text = "Hello World International By Connor Quinlan";
            this.grbLanguages.ResumeLayout(false);
            this.grbLanguages.PerformLayout();
            this.mnuExit.ResumeLayout(false);
            this.mnuExit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.GroupBox grbLanguages;
        private System.Windows.Forms.RadioButton radRussian;
        private System.Windows.Forms.RadioButton radGerman;
        private System.Windows.Forms.RadioButton radFrench;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.MenuStrip mnuExit;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

