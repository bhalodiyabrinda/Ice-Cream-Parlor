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
    public partial class ALogin : Form
    {
        string q;
        string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET\\Project\\Ice-Cream parler\\Admin.mdf\";Integrated Security=True";

        public ALogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            q = "SELECT COUNT(1) FROM [dbo].[ALogin] WHERE Username=@Username AND Password=@Password";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Username", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            if (count == 1)
            {
                MessageBox.Show("Login Successful");

                AdminPanal adminPanal = new AdminPanal();
                adminPanal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                ALogin aLogin = new ALogin();
                aLogin.Show();
                this.Hide();
            }
        }
    }
}
