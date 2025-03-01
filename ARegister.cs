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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ice_Cream_parler
{
    public partial class ARegister : Form
    {
        string q;
        string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET\\Project\\Ice-Cream parler\\Admin.mdf\";Integrated Security=True";

        public ARegister()
        {
            InitializeComponent();
            LoadALoginData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            q = "insert into [dbo].[ALogin] (Username, Password) values(@Username, @Password)";
            SqlCommand cmd = new SqlCommand(q, con);


            cmd.Parameters.AddWithValue("@Username", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);

            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminPanal adminPanal = new AdminPanal();
            adminPanal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            q = "DELETE FROM [dbo].[Register] WHERE Username = @Username";

            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@Username", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);

            cmd.ExecuteNonQuery();
            con.Close();

        }
        private void LoadALoginData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    // Open the connection
                    con.Open();

                    // SQL query to fetch all records from the ALogin table
                    q = "SELECT * FROM [dbo].[ALogin]";

                    // Create SqlDataAdapter to fetch data from the database
                    SqlDataAdapter adapter = new SqlDataAdapter(q, con);

                    // Create a DataTable to hold the result
                    DataTable dt = new DataTable();

                    // Fill the DataTable with the query result
                    adapter.Fill(dt);

                    // Bind the DataTable to the Guna2DataGridView
                    guna2DataGridView1.DataSource = dt;

                    // Close the connection
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                // Display error if there's any issue in fetching the data
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                // Populate the textboxes with the clicked row data
                textBox1.Text = row.Cells["Username"].Value.ToString();
                textBox2.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            ACups ACups = new ACups();
            ACups.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AFamilyPack aFamilyPack = new AFamilyPack();
            aFamilyPack.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ACones aCones = new ACones();
            aCones.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ACandies aCandies = new ACandies();
            aCandies.Show();
            this.Hide();
        }
    }
}
