using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;

namespace Ice_Cream_parler
{
    public partial class Login : Form
    {
        string q;
        string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET\\Project\\Ice-Cream parler\\Admin.mdf\";Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            q = "SELECT COUNT(1) FROM [dbo].[Register] WHERE Username=@Username AND Password=@Password";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Username", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            if (count == 1)
            {
                MessageBox.Show("Login Successful");
                Home H = new Home();
                H.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");

                Login login = new Login();
                login.Show();
                this.Hide();
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {
            Register R = new Register();
            R.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ALogin login = new ALogin();
            login.Show();
            this.Hide();
        }
    }
}
