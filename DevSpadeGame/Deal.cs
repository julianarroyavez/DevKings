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
    public partial class Deal : Form
    {
        public Deal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] letters = "AKQJ23456789".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 13; i++)
            {
                randomString += letters[r.Next(2, 10)].ToString();
            }
            MessageBox.Show(randomString);
        }
    }
}
