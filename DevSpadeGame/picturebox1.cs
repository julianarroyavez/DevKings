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
    public partial class picturebox1 : Form
    {
        public picturebox1()
        {
            InitializeComponent();
        }

        private void Picturebox1_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"background.jpg");
            card1.Image = img;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
