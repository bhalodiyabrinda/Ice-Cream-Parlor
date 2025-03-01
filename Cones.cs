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
    public partial class Cones : Form
    {
        public Cones()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Family_Pack fa = new Family_Pack();
            //fa.Show();
            //this.Close();
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

        private void label5_Click_1(object sender, EventArgs e)
        {
            Cups cu = new Cups();
            cu.Show();
            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Cones co = new Cones();
            co.Show();
            this.Close();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Candies ca = new Candies();
            ca.Show();
            this.Close();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            FamilyPack fa = new FamilyPack();
            fa.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RedVelvet ReCone = new RedVelvet();
            ReCone.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            KajuDraksh KaCone = new KajuDraksh();
            KaCone.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CookieMagic CoCone = new CookieMagic();
            CoCone.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            ChocoJunior ChCone = new ChocoJunior();
            ChCone.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Blackcurrant BlCone = new Blackcurrant();
            BlCone.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ArabianFantasy ArCone = new ArabianFantasy();
            ArCone.Show();
            this.Hide();
        }
    }
}
