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
    public partial class frmDashboard : Form
    {
        Timer timer = new Timer();

        public frmDashboard()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmDashboard_Load);

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login myLogin = new Login();
            myLogin.Show();
            this.Hide();
        }

        private void btnReserve_Click_1(object sender, EventArgs e)
        {
            btnMngLib.FlatStyle = FlatStyle.Flat;
            btnMngLib.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ViewTransactions myform = new ViewTransactions();
            myform.Show();
            this.Hide();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // Set label font
            label3.Font = new Font("Century Gothic", 7, FontStyle.Regular);

            // Set initial time
            label3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Set up timer
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += (s, args) =>
            {
                label3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            };
            timer.Start();

            getData();
        }

        private void Panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addbooks_Click_3(object sender, EventArgs e)
        {
            
        }

        public void getData()
        {
            string conString = "server=localhost;uid=root;password=fabian;database=library_management_system;";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT book_id, title, author_id, status FROM books";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Set the DataGridView data source
                    dataGridView1.DataSource = dt;

                    // Make DataGridView clean and view-only
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.AllowUserToResizeRows = false;
                    dataGridView1.AllowUserToResizeColumns = false;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.MultiSelect = false;

                    // Styling for clean appearance
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.BackgroundColor = Color.White;
                    dataGridView1.BorderStyle = BorderStyle.None;
                    dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                    dataGridView1.EnableHeadersVisualStyles = false;

                    // Optional: Customize column header style
                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
                    dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);

                    // Optional: Customize row style
                    dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 10);
                    dataGridView1.DefaultCellStyle.ForeColor = Color.DimGray;
                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                    dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;



                    dataGridView1.Columns["book_id"].HeaderText = "Book ID";
                    dataGridView1.Columns["title"].HeaderText = "Title";
                    dataGridView1.Columns["author_id"].HeaderText = "Author ID";
                    dataGridView1.Columns["status"].HeaderText = "Status";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAuthors_Click_1(object sender, EventArgs e)
        {
            Manage myform = new Manage();
            myform.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard myform = new frmDashboard();
            myform.Show();
            this.Hide();
        }

        private void btnMngLib_Click(object sender, EventArgs e)
        {
            ManageLibrary myform = new ManageLibrary();
            myform.Show();
            this.Hide();
        }
    }
}
