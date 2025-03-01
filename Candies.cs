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
    public partial class Candies : Form
    {
        public Candies()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Candies ca = new Candies();
            ca.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Cones co = new Cones();
            co.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Cups cu = new Cups();
            cu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Cups cu = new Cups();
            cu.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Cones co = new Cones();
            co.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Candies ca = new Candies();
            ca.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            FamilyPack fa = new FamilyPack();
            fa.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            KacchaMango KaCandy = new KacchaMango();
            KaCandy.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OrangeBar OrCandy = new OrangeBar();
            OrCandy.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MangoDolly MaCandy = new MangoDolly();
            MaCandy.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Raspberry RaCandy = new Raspberry();
            RaCandy.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Chocobar ChCandy = new Chocobar();
            ChCandy.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MawaMalai MaCandy = new MawaMalai();
            MaCandy.Show();
            this.Hide();

        }
    }
}
