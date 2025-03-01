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
    public partial class StrawberryCup : Form
    {
        public StrawberryCup()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Cups cu = new Cups();
            cu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CupsOrder cupsOrder = new CupsOrder();
            cupsOrder.Show();
            this.Hide();
        }
    }
}
