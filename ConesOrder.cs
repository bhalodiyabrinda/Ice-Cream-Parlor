using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ice_Cream_parler
{
    public partial class ConesOrder : Form
    {
        string q;
        string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET\\Project\\Ice-Cream parler\\Admin.mdf\";Integrated Security=True";

        public ConesOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            q = "insert into [dbo].[Cones] (PackagingType, Flavour, Adderss, Piece) values(@PackagingType, @Flavour ,@Adderss, @Piece)";
            SqlCommand cmd = new SqlCommand(q, con);

            cmd.Parameters.AddWithValue("@PackagingType", comboBox3.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Flavour", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Adderss", textBox3.Text);
            cmd.Parameters.AddWithValue("@Piece", comboBox2.SelectedItem.ToString());

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Order Successful");

            Home h = new Home();
            h.Show();
            this.Close();
        }
    }
}
