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
    public partial class Reserve : Form
    {
        public Reserve()
        {
            InitializeComponent();
        }

        private void LoadReservations()
        {
            string connectionString = "server=localhost;uid=root;password=fabian;database=library_management_system;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                                    SELECT 
                                        reservation_id, 
                                        user_id, 
                                        book_id, 
                                        reservation_date
                                    FROM 
                                        reservations
                                    ORDER BY 
                                        reservation_date DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    Borrowedbooks.DataSource = dt; // Assuming your DataGridView is named Borrowedbooks

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

                    // Header renaming
                    Borrowedbooks.Columns["reservation_id"].HeaderText = "Reservation ID";
                    Borrowedbooks.Columns["user_id"].HeaderText = "User ID";
                    Borrowedbooks.Columns["book_id"].HeaderText = "Book ID";
                    Borrowedbooks.Columns["reservation_date"].HeaderText = "Reservation Date";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load reservations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bookReserve_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;password=fabian;database=library_management_system;";
            string userName = name.Text.Trim();
            string userEmail = email.Text.Trim();
            string userPhone = phone.Text.Trim();
            string userAddress = address.Text.Trim();
            string bookIdVal = bookId.Text.Trim();
            string reservationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Input validation
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userEmail) ||
                string.IsNullOrEmpty(userPhone) || string.IsNullOrEmpty(userAddress) ||
                string.IsNullOrEmpty(bookIdVal))
            {
                MessageBox.Show("Please complete all user and book information.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    long userId;

                    // Step 1: Check if user already exists based on name + email (for better uniqueness)
                    string checkUserQuery = "SELECT user_id FROM users WHERE name = @name AND email = @email";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkUserQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@name", userName);
                        checkCmd.Parameters.AddWithValue("@email", userEmail);
                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            userId = Convert.ToInt64(result); // existing user ID
                        }
                        else
                        {
                            // Step 2: Insert new user with full details
                            string insertUserQuery = @"INSERT INTO users (name, email, phone, address) 
                                               VALUES (@name, @email, @phone, @address)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertUserQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@name", userName);
                                insertCmd.Parameters.AddWithValue("@email", userEmail);
                                insertCmd.Parameters.AddWithValue("@phone", userPhone);
                                insertCmd.Parameters.AddWithValue("@address", userAddress);
                                insertCmd.ExecuteNonQuery();
                                userId = insertCmd.LastInsertedId;
                            }
                        }
                    }

                    // Step 3: Insert reservation
                    // Step 3: Insert reservation with status = 'reserved'
                    string insertReservationQuery = @"INSERT INTO reservations (user_id, book_id, reservation_date, status)
                                  VALUES (@user_id, @book_id, @reservation_date, @status)";
                    using (MySqlCommand reservationCmd = new MySqlCommand(insertReservationQuery, conn))
                    {
                        reservationCmd.Parameters.AddWithValue("@user_id", userId);
                        reservationCmd.Parameters.AddWithValue("@book_id", bookIdVal);
                        reservationCmd.Parameters.AddWithValue("@reservation_date", reservationDate);
                        reservationCmd.Parameters.AddWithValue("@status", "reserved");  // Set default status

                        int reservationResult = reservationCmd.ExecuteNonQuery();
                        if (reservationResult > 0)
                        {
                            MessageBox.Show("Book reserved successfully!");
                            LoadReservations(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Reservation failed.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void btnborrow_Click(object sender, EventArgs e)
        {
            Transactions myLogin = new Transactions();
            myLogin.Show();
            this.Hide();
        }

        private void btnLibrarian_Click(object sender, EventArgs e)
        {
            LIbrarian myLogin = new LIbrarian();
            myLogin.Show();
            this.Hide();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            Reserve myLogin = new Reserve();
            myLogin.Show();
            this.Hide();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reserve_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void innerborrow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
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

        private void Borrowedbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
