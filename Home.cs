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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FamilyPack fa = new FamilyPack();
            fa.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Cups cu = new Cups();
            cu.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Cones co = new Cones();
            co.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Candies ca = new Candies();
            ca.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChocolateCup chocolate = new ChocolateCup();
            chocolate.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Raspberry RaCandy = new Raspberry();
            RaCandy.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            KacchaMango KaCandy = new KacchaMango();
            KaCandy.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AmericanNutsCup AmCup = new AmericanNutsCup();
            AmCup.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ArabianFantasy ArCone = new ArabianFantasy();
            ArCone.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
