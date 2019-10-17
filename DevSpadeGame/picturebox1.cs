using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevSpadeGame
{
    public partial class picturebox1 : Form
    {
        public picturebox1()
        {
            InitializeComponent();
        }


        private void Bid1_Click(object sender, EventArgs e)
        {
            BidPanel.Hide();
           
        }

        

        private void Picturebox1_Load(object sender, EventArgs e)
        {
           Image img = Image.FromFile(Application.StartupPath + "/"  + @"cards/10C.png");
           P1C1.Image = img;
        }

        private void PictureBox4_Click(object sender, EventArgs e)

        {

        }

        private void Bid2_Click(object sender, EventArgs e)
        {
            BidPanel.Hide();

        

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void bid3_Click(object sender, EventArgs e)
        {
            Deal myNewForm = new Deal();

            myNewForm.Show();
        }

        private void bid4_Click(object sender, EventArgs e)
        {
            Deal myNewForm = new Deal();

            myNewForm.Show();
        }

        private void bid5_Click(object sender, EventArgs e)
        {
            Deal myNewForm = new Deal();

            myNewForm.Show();
        }

        private void bid6_Click(object sender, EventArgs e)
        {
            Deal myNewForm = new Deal();

            myNewForm.Show();
        }

        private void bid7_Click(object sender, EventArgs e)
        {
            Deal myNewForm = new Deal();

            myNewForm.Show();
        }

        private void bid8_Click(object sender, EventArgs e)
        {
            Deal myNewForm = new Deal();

            myNewForm.Show();
        }

        private void bid9_Click(object sender, EventArgs e)
        {
            Deal myNewForm = new Deal();

            myNewForm.Show();
        }

        private void bid10_Click(object sender, EventArgs e)
        {
            Deal myNewForm = new Deal();

            myNewForm.Show();
        }

        private void bid11_Click(object sender, EventArgs e)
        {
            Deal myNewForm = new Deal();

            myNewForm.Show();
        }

        private void bid12_Click(object sender, EventArgs e)
        {
            Deal myNewForm = new Deal();

            myNewForm.Show();
        }

        private void bid13_Click(object sender, EventArgs e)
        {
            Deal myNewForm = new Deal();

            myNewForm.Show();
        }

        private void P1C1_Click(object sender, EventArgs e)
        {

        }

        private void P1C13_Click(object sender, EventArgs e)
        {

        }
    }
}




