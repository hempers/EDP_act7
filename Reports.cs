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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Activity7
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;uid=root;password=fabian;database=library_management_system;";

        private void borrow_Click(object sender, EventArgs e)
        {
            string user_id = UserId.Text;
            string book_id= BookId.Text;
            string dateFrom = borrowdate.Value.ToString("yyyy-MM-dd");
            string dateTo = duedate.Value.ToString("yyyy-MM-dd");

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO borrowedbooks (user_id ,book_id, borrow_date, return_date) VALUES (@user_id, @book_id, @borrow_date, @return_date)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@book_id", book_id);
                    cmd.Parameters.AddWithValue("@borrow_date", dateFrom);
                    cmd.Parameters.AddWithValue("@return_date", dateTo);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Borrow record saved successfully!");
                    LoadBorrowedBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadBorrowedBooks()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT borrow_id, user_id, book_id, borrow_date FROM borrowedbooks";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    Borrowedbooks.DataSource = dt;

                    // Customize DataGridView appearance
                    Borrowedbooks.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
                    Borrowedbooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    Borrowedbooks.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);

                    Borrowedbooks.DefaultCellStyle.Font = new Font("Century Gothic", 10);
                    Borrowedbooks.DefaultCellStyle.ForeColor = Color.DimGray;
                    Borrowedbooks.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                    Borrowedbooks.DefaultCellStyle.SelectionForeColor = Color.White;

                    Borrowedbooks.Columns["borrow_id"].HeaderText = "Borrow ID";
                    Borrowedbooks.Columns["user_id"].HeaderText = "User ID";
                    Borrowedbooks.Columns["book_id"].HeaderText = "Book ID";
                    Borrowedbooks.Columns["borrow_date"].HeaderText = "Borrow Date";

                    Borrowedbooks.EnableHeadersVisualStyles = false; // Ensures custom header styles apply
                    Borrowedbooks.AllowUserToAddRows = false;
                    Borrowedbooks.RowHeadersVisible = false;


                    Borrowedbooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Optional: fills grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading borrowed books: " + ex.Message);
                }
            }
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabBorrowed_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tabOverdue3_Click(object sender, EventArgs e)
        {

        }

       
        private void Borrowedbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bookStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnshowRecords_Click(object sender, EventArgs e)
        {

        }

        private void overdue_logbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUserid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showFine_Click(object sender, EventArgs e)
        {
              
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LoadBorrowedBooks();
        }

        private void BookId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
