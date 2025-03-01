using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ice_Cream_parler
{
    public partial class Cups : Form
    {
        public Cups()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FamilyPack fa = new FamilyPack();
            fa.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Candies ca = new Candies();
            ca.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Cones co = new Cones();
            co.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Cups cu = new Cups();
            cu.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            ChocolateCup chCup = new ChocolateCup();
            chCup.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StrawberryCup StCup = new StrawberryCup();
            StCup.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MangoCup maCup = new MangoCup();
            maCup.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AmericanNutsCup AmCup = new AmericanNutsCup();
            AmCup.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            VanillaCup VaCup = new VanillaCup();
            VaCup.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            KesarCup KeCup = new KesarCup();
            KeCup.Show();
            this.Hide();
        }
    }
}
