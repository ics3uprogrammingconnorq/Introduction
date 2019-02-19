/*
 * Created by: Connor Quinlan
 * Created on: 18-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 Hello World International
 * This program allows the user to pick a language in which the program will display hello world in that language.
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

namespace HelloWorldIntConnorQ
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // When English is pressed change language to English
        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = "Hello, World!";
        }

        // When French is pressed change language to French
        private void radFrench_CheckedChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = "Bonjour, Le Monde!";
        }

        // When German is pressed change language to German
        private void radGerman_CheckedChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = "Hallo, Welt!";
        }

        // When Russian is pressed change language to Russian
        private void radRussian_CheckedChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = "Привет, мир!";
        }

        // When Exit is pressed close the program
        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblGreetings_Click(object sender, EventArgs e)
        {

        }
    }
}
