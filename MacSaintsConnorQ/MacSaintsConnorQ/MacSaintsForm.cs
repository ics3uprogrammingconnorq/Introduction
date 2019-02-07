/*
 * Created by: Connor Quinlan
 * Created on: Feb 7, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - School App with Menu
 * This program displays Mac Saints but with an exit menu
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacSaintsConnorQ
{
    public partial class frmMacSaints : Form
    {
        public frmMacSaints()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close the program
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


