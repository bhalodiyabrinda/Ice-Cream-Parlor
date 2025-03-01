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
    public partial class AFamilyPack : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\.NET\\Project\\Ice-Cream parler\\Admin.mdf\";Integrated Security=True";


        public AFamilyPack()
        {
            InitializeComponent();
            LoadFamilyPackData();
        }
        private void LoadFamilyPackData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM FamilyPack";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    guna2DataGridView1.DataSource = dataTable;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["Id"].Value);
                string packagingType = row.Cells["PackagingType"].Value.ToString();
                string flavour = row.Cells["Flavour"].Value.ToString();
                string address = row.Cells["Adderss"].Value.ToString();  
                string piece = row.Cells["Piece"].Value.ToString();

                MessageBox.Show($"ID: {id}\nPackaging Type: {packagingType}\nFlavour: {flavour}\nAddress: {address}\nPiece: {piece}");
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

        private void label1_Click(object sender, EventArgs e)
        {
            AdminPanal adminPanal = new AdminPanal();
            adminPanal.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ARegister aRegister = new ARegister();
            aRegister.Show();
            this.Hide();
        }
    }
}
