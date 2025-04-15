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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadTableToGrid(string tableName, DataGridView grid)
        {
            string conString = "server=localhost;uid=root;password=fabian;database=library_management_system;";
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();
                string query = $"SELECT * FROM {tableName}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                grid.DataSource = dt;
                reader.Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard myform = new frmDashboard();
            myform.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnMng_Click(object sender, EventArgs e)
        {
            Manage myform = new Manage();
            myform.Show();
            this.Hide();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnData_Click_1(object sender, EventArgs e)
        {
            LoadTableToGrid("authors", dataGridView1);
            LoadTableToGrid("users", dataGridView2);
            LoadTableToGrid("categories", dataGridView3);
            LoadTableToGrid("borrowedbooks", dataGridView4);
        }
    }
}
