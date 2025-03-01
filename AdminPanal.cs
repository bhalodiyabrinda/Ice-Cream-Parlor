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
    public partial class AdminPanal : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET\\Project\\Ice-Cream parler\\Admin.mdf\";Integrated Security=True";

        public AdminPanal()
        {
            InitializeComponent();
            LoadRegisterData();
        }
        private void LoadRegisterData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();  

                    string query = "SELECT * FROM Register";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    guna2DataGridView1.DataSource = dataTable;

                    conn.Close();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                    int id = Convert.ToInt32(row.Cells["Id"].Value);  
                    string email = row.Cells["Email"].Value.ToString();
                    string username = row.Cells["Username"].Value.ToString();
                    string password = row.Cells["Password"].Value.ToString();
                    string mobile = row.Cells["Mobail"].Value.ToString();  

                    MessageBox.Show($"ID: {id}\nEmail: {email}\nUsername: {username}\nPassword: {password}\nMobile: {mobile}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ACups ACups = new ACups();
            ACups.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            ACandies aCandies = new ACandies();
            aCandies.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ACones aCones = new ACones();
            aCones.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AFamilyPack aFamilyPack = new AFamilyPack();
            aFamilyPack.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ARegister aRegister = new ARegister();
            aRegister.Show();
            this.Hide();
        }
    }

}
