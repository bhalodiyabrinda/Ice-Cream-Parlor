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
    public partial class CookieMagic : Form
    {
        public CookieMagic()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Cones co = new Cones();
            co.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConesOrder conesOrder = new ConesOrder();
            conesOrder.Show();
            this.Hide();
        }
    }
}
