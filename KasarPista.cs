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
    public partial class KasarPista : Form
    {
        public KasarPista()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FamilyPack fa = new FamilyPack();
            fa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FamilyPackOrder familyPackOrder = new FamilyPackOrder();
            familyPackOrder.Show();
            this.Hide();
        }
    }
}
