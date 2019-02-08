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

        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = "Hello, World!";
        }

        private void radFrench_CheckedChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = "Bonjour, Le Monde!";
        }

        private void radGerman_CheckedChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = "Hallo, Welt!";
        }

        private void radRussian_CheckedChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = "Привет, мир!";
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblGreetings_Click(object sender, EventArgs e)
        {

        }
    }
}
