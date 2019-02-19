/*
 * Created by: Connor Quinlan
 * Created on: 11-2-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Perimeter, Area and Volume
 * This program asks math problems and are answered when you press on the button.
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

namespace PerAreaVolConnorQ
{
    public partial class frmPerAreaVol : Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }

        private void PerAreaVolForm_Load(object sender, EventArgs e)
        {

        }

        // When first question is pressed show answer
        private void btnPerOfRectangle_Click(object sender, EventArgs e)
        {
            lblAnswer1.Text = Convert.ToString((2*7)+(2*9));
        }

        // When second question is pressed show answer
        private void btnAreaOfCircle_Click(object sender, EventArgs e)
        {
            lblAnswer2.Text = Convert.ToString(Math.Round(100 * Math.Pow(9 / 2, 2) * Math.PI)/100);
        }

        // When third question is pressed show answer
        private void btnVolumeOfSphere_Click(object sender, EventArgs e)
        {
            lblAnswer3.Text = Convert.ToString(Math.Round(100*((double)4/(double)3)*(Math.PI)*(Math.Pow(6, 3)))/100);
        }
    }
}
