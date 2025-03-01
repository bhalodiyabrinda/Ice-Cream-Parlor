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
    public partial class Register : Form
    {
        string q;
        string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET\\Project\\Ice-Cream parler\\Admin.mdf\";Integrated Security=True";

        public Register()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            q = "insert into [dbo].[Register] (Id, Email, Username, Password, Mobail) values(@Id, @Email ,@Username, @Password, @Mobail)";
            SqlCommand cmd = new SqlCommand(q, con);

            cmd.Parameters.AddWithValue("@Id", textBox5.Text);
            cmd.Parameters.AddWithValue("@Email", textBox1.Text);
            cmd.Parameters.AddWithValue("@Username", textBox2.Text);
            cmd.Parameters.AddWithValue("@Password", textBox3.Text);
            cmd.Parameters.AddWithValue("@Mobail", textBox4.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Register Successfully");

            Login L = new Login();
            L.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            q = "UPDATE [dbo].[Register] SET Email = @Email, Username = @Username, Password = @Password, Mobail = @Mobail WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Id", textBox5.Text);
            cmd.Parameters.AddWithValue("@Email", textBox1.Text);
            cmd.Parameters.AddWithValue("@Username", textBox2.Text);
            cmd.Parameters.AddWithValue("@Password", textBox3.Text);
            cmd.Parameters.AddWithValue("@Mobail", textBox4.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully");

            Login L = new Login();
            L.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            q = "DELETE FROM [dbo].[Register] WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Id", textBox5.Text);
            cmd.Parameters.AddWithValue("@Email", textBox1.Text);
            cmd.Parameters.AddWithValue("@Username", textBox2.Text);
            cmd.Parameters.AddWithValue("@Password", textBox3.Text);
            cmd.Parameters.AddWithValue("@Mobail", textBox4.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Delete Successfully");

            Login L = new Login();
            L.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.Hide();
        }
    }
}
