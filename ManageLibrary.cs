using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Activity7
{


    public partial class ManageLibrary : Form
    {
        public class DatabaseHelper
        {
            private readonly string _connectionString = "server=localhost;uid=root;password=fabian;database=library_management_system;";

            public DataTable ReadAll(string tableName)
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = $"SELECT * FROM {tableName}";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        private DatabaseHelper _dbHelper = new DatabaseHelper();

        private void LoadData()
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                // Load data
                librarians.DataSource = db.ReadAll("librarians");
                authors.DataSource = db.ReadAll("authors");
                categories.DataSource = db.ReadAll("categories");

                // Apply styles and set read-only
                FormatDataGridView(librarians);
                FormatDataGridView(authors);
                FormatDataGridView(categories);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            // Add more tables as needed
        }

        private void FormatDataGridView(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // <-- ensures text fits

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);

            dgv.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            dgv.DefaultCellStyle.ForeColor = Color.DimGray;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;

        }


        public ManageLibrary()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMng_Click(object sender, EventArgs e)
        {
            Manage myform = new Manage();
            myform.Show();
            this.Hide();
        }


        private void ManageLibrary_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDashboard myform = new frmDashboard();
            myform.Show();
            this.Hide();
        }

        private void librarians_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void authors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void authors_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void librarians_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void transac_Click(object sender, EventArgs e)
        {
            ViewTransactions myform = new ViewTransactions();
            myform.Show();
            this.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Login myform = new Login();
            myform.Show();
            this.Hide();
        }
    }
}
