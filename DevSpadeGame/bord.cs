﻿using System;
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
    public partial class bord : Form
    {
        public bord()
        {
            InitializeComponent();
        }

        private void Bord_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            startmenu.Hide();
            DificultPanel.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            Rules myNewForm = new Rules();

            myNewForm.Show();
            

        }


        private void Eassybutton_Click(object sender, EventArgs e)
        {
           picturebox1 myNewForm = new picturebox1();

            myNewForm.Show();
        }

        private void BidPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Standardbutton_Click(object sender, EventArgs e)
        {
            picturebox1 myNewForm = new picturebox1();

            myNewForm.Show();
        }


        private void Probutton_Click_1(object sender, EventArgs e)
        {
            picturebox1 myNewForm = new picturebox1();

            myNewForm.Show();
        }

        private void winnerbtn_Click(object sender, EventArgs e)
        {
            last myNewForm = new last();

            myNewForm.Show();

        }

        private void drawimgbutton_Click(object sender, EventArgs e)
        {

            Image img = Image.FromFile(@"C:\Users\Programming10\Desktop\DevKings\DevSpadeGame\cards\10_of_clubs.png");
            //pictureBox1.Image = img;

  
            
        }

        private void DificultPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
