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
    public partial class MawaMalai : Form
    {
        public MawaMalai()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Candies ca = new Candies();
            ca.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CandiesOrder candiesOrder = new CandiesOrder();
            candiesOrder.Show();
            this.Hide();
        }
    }
}
