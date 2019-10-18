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

            List<int> listCards = new List<int>();

            for (int i = 0; i < 52; i++)
            {
                listCards.Add(i);
            }

            List<int> player1 = new List<int>();

            //List<int> lCards = listCards.Where(x => x > 0).ToList<int>();

            for (int i = 0; i < 13; i++)
            {
                Random r = new Random(DateTime.Now.Millisecond);
                var position = r.Next(0, listCards.Count());
                var card = listCards.ElementAt(position);
                player1.Add(card);
                var itemToRemove = listCards.Single(d => d == card);
                listCards.Remove(itemToRemove);
            }


            var dictionaryCards = new Dictionary<int, string>() {
                {1,@"cards/AC.png" },
                {2,@"cards/2C.png" },
                {3,@"cards/3C.png" },
                {4,@"cards/4C.png" },
                {5,@"cards/5C.png" },
                {6,@"cards/6C.png" },
                {7,@"cards/7C.png" },
                {8,@"cards/8C.png" },
                {9,@"cards/9C.png" },
                {10,@"cards/10C.png" },
                {11,@"cards/JC.png" },
                {12,@"cards/QC.png" },
                {13,@"cards/KC.png" },
                {14,@"cards/AD.png" },
                {15,@"cards/2D.png" },
                {16,@"cards/3D.png" },
                {17,@"cards/4D.png" },
                {18,@"cards/5D.png" },
                {19,@"cards/6D.png" },
                {20,@"cards/7D.png" },
                {21,@"cards/8D.png" },
                {22,@"cards/9D.png" },
                {23,@"cards/10D.png" },
                {24,@"cards/JD.png" },
                {25,@"cards/QD.png" },
                {26,@"cards/KD.png" },
                {27,@"cards/AH.png" },
                {28,@"cards/2H.png" },
                {29,@"cards/3H.png" },
                {30,@"cards/4H.png" },
                {31,@"cards/5H.png" },
                {32,@"cards/6H.png" },
                {33,@"cards/7H.png" },
                {34,@"cards/8H.png" },
                {35,@"cards/9H.png" },
                {36,@"cards/10H.png" },
                {37,@"cards/JH.png" },
                {38,@"cards/QH.png" },
                {39,@"cards/KH.png" },
                {40,@"cards/AS.png" },
                {41,@"cards/2S.png" },
                {42,@"cards/3S.png" },
                {43,@"cards/4S.png" },
                {44,@"cards/5S.png" },
                {45,@"cards/6S.png" },
                {46,@"cards/7S.png" },
                {47,@"cards/8S.png" },
                {48,@"cards/9S.png" },
                {49,@"cards/10S.png" },
                {50,@"cards/JS.png" },
                {51,@"cards/QS.png" },
                {52,@"cards/KS.png" }

            };



            Image img = Image.FromFile(Application.StartupPath + "/" + dictionaryCards[player1[0]]);
            P1C1.Image = img;
            img = Image.FromFile(Application.StartupPath + "/" + dictionaryCards[player1[1]]);
            P1C2.Image = img;
            img = Image.FromFile(Application.StartupPath + "/" + dictionaryCards[player1[2]]);
            P1C3.Image = img;
            img = Image.FromFile(Application.StartupPath + "/" + dictionaryCards[player1[3]]);
            P1C4.Image = img;
            img = Image.FromFile(Application.StartupPath + "/" + dictionaryCards[player1[4]]);
            P1C5.Image = img;
            img = Image.FromFile(Application.StartupPath + "/" + dictionaryCards[player1[5]]);
            P1C6.Image = img;
            img = Image.FromFile(Application.StartupPath + "/" + dictionaryCards[player1[6]]);
            P1C7.Image = img;
            img = Image.FromFile(Application.StartupPath + "/" + dictionaryCards[player1[7]]);
            P1C8.Image = img;
            img = Image.FromFile(Application.StartupPath + "/" + dictionaryCards[player1[8]]);
            P1C9.Image = img;
            img = Image.FromFile(Application.StartupPath + "/" + dictionaryCards[player1[9]]);
            P1C10.Image = img;
            img = Image.FromFile(Application.StartupPath + "/" + dictionaryCards[player1[10]]);
            P1C11.Image = img;
            img = Image.FromFile(Application.StartupPath + "/" + dictionaryCards[player1[11]]);
            P1C12.Image = img;
            img = Image.FromFile(Application.StartupPath + "/" + dictionaryCards[player1[12]]);
            P1C13.Image = img;





        }

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
