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
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void LoadBorrowedBooks()
        {
            string connectionString = "server=localhost;uid=root;password=fabian;database=library_management_system;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                                    SELECT 
                                        borrow_id, 
                                        user_id, 
                                        book_id, 
                                        borrow_date
                                    FROM 
                                        borrowedbooks
                                    ORDER BY 
                                        borrow_date DESC";  // latest borrow date first

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    Borrowedbooks.DataSource = dt;

                    // DataGridView properties and styling for readability
                    Borrowedbooks.ReadOnly = true;
                    Borrowedbooks.AllowUserToAddRows = false;
                    Borrowedbooks.AllowUserToDeleteRows = false;
                    Borrowedbooks.AllowUserToResizeRows = false;
                    Borrowedbooks.AllowUserToResizeColumns = false;
                    Borrowedbooks.RowHeadersVisible = false;
                    Borrowedbooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    Borrowedbooks.MultiSelect = false;

                    Borrowedbooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    Borrowedbooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    Borrowedbooks.BackgroundColor = Color.White;
                    Borrowedbooks.BorderStyle = BorderStyle.None;
                    Borrowedbooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    Borrowedbooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                    Borrowedbooks.EnableHeadersVisualStyles = false;

                    Borrowedbooks.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
                    Borrowedbooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    Borrowedbooks.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Bold);

                    Borrowedbooks.DefaultCellStyle.Font = new Font("Century Gothic", 8);
                    Borrowedbooks.DefaultCellStyle.ForeColor = Color.DimGray;
                    Borrowedbooks.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                    Borrowedbooks.DefaultCellStyle.SelectionForeColor = Color.White;

                    // Rename headers for clarity
                    Borrowedbooks.Columns["borrow_id"].HeaderText = "Borrow ID";
                    Borrowedbooks.Columns["user_id"].HeaderText = "User ID";
                    Borrowedbooks.Columns["book_id"].HeaderText = "Book ID";
                    Borrowedbooks.Columns["borrow_date"].HeaderText = "Borrow Date";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load borrowed books: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Transactions_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        private void btnTransac_Click(object sender, EventArgs e)
        {

        }

        private void innerborrow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnborrow_Click(object sender, EventArgs e)
        {
            Transactions myLogin = new Transactions();
            myLogin.Show();
            this.Hide();
        }

        private void Borrowedbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            Reserve myLogin = new Reserve();
            myLogin.Show();
            this.Hide();
        }

        private void btnLibrarian_Click(object sender, EventArgs e)
        {
            LIbrarian myLogin = new LIbrarian();
            myLogin.Show();
            this.Hide();
        }

        private void borrow_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;password=fabian;database=library_management_system;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Use transaction for atomicity
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Get input values
                        string name = txtName.Text.Trim();
                        string email = Email.Text.Trim();
                        string phoneNumber = phone.Text.Trim();
                        string addressText = address.Text.Trim();
                        string bookID = bookId.Text.Trim();
                        DateTime borrowDate = borrowdate.Value;
                        DateTime dueDate = duedate.Value;

                        // 1. Insert user (optional: check if user already exists to avoid duplicates)
                        string insertUserQuery = @"INSERT INTO users (name, email, phone, address) 
                                           VALUES (@name, @email, @phone, @address);
                                           SELECT LAST_INSERT_ID();";

                        long userId;

                        using (MySqlCommand cmdUser = new MySqlCommand(insertUserQuery, conn, transaction))
                        {
                            cmdUser.Parameters.AddWithValue("@name", name);
                            cmdUser.Parameters.AddWithValue("@email", email);
                            cmdUser.Parameters.AddWithValue("@phone", phoneNumber);
                            cmdUser.Parameters.AddWithValue("@address", addressText);

                            // ExecuteScalar returns the last inserted ID for users table
                            userId = Convert.ToInt64(cmdUser.ExecuteScalar());
                        }

                        // 2. Insert borrowedbooks entry linking user and book
                        string insertBorrowQuery = @"INSERT INTO borrowedbooks (user_id, book_id, borrow_date, due_date) 
                                             VALUES (@user_id, @book_id, @borrow_date, @due_date)";

                        using (MySqlCommand cmdBorrow = new MySqlCommand(insertBorrowQuery, conn, transaction))
                        {
                            cmdBorrow.Parameters.AddWithValue("@user_id", userId);
                            cmdBorrow.Parameters.AddWithValue("@book_id", bookID);
                            cmdBorrow.Parameters.AddWithValue("@borrow_date", borrowDate);
                            cmdBorrow.Parameters.AddWithValue("@due_date", dueDate);

                            cmdBorrow.ExecuteNonQuery();
                        }

                        // 3. Update book status
                        string updateStatus = "UPDATE books SET status = 'Borrowed' WHERE book_id = @book_id";
                        using (MySqlCommand cmdUpdate = new MySqlCommand(updateStatus, conn, transaction))
                        {
                            cmdUpdate.Parameters.AddWithValue("@book_id", bookID);
                            cmdUpdate.ExecuteNonQuery();
                        }

                        // Commit the transaction if all successful
                        transaction.Commit();

                        MessageBox.Show("Book successfully borrowed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBorrowedBooks(); // refresh grid
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch { /* Handle rollback exception if needed */ }

                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookId_TextChanged(object sender, EventArgs e)
        {

        }

        private void booktitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void borrowdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void duedate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void genReport_Click(object sender, EventArgs e)
        {
            Generate_Report myform = new Generate_Report();
            myform.Show();
            this.Hide();
        }
    }
}
