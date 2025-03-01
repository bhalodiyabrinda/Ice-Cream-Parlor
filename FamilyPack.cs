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
    public partial class FamilyPack : Form
    {
        public FamilyPack()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
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

        private void label4_Click(object sender, EventArgs e)
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
            CrunchyButterscotch CrF = new CrunchyButterscotch();
            CrF.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChocoBrownie Chf = new ChocoBrownie();
            Chf.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FruitBonaza FrF = new FruitBonaza();
            FrF.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            KasarPista KaF = new KasarPista();
            KaF.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Staawberry StF = new Staawberry();
            StF.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BlackCurrantF BlF = new BlackCurrantF();
            BlF.Show();
            this.Hide();
        }
    }
}
