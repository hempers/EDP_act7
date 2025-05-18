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
    public partial class LIbrarian : Form
    {
        public LIbrarian()
        {
            InitializeComponent();
        }

        private void LIbrarian_Load(object sender, EventArgs e)
        {
            LoadLibrarians();
        }

        private void LoadLibrarians()
        {
            string connectionString = "server=localhost;uid=root;password=fabian;database=library_management_system;";
            string query = "SELECT librarian_id, name, salary FROM librarians";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        Borrowedbooks.DataSource = dt; // Assuming this is your DataGridView for librarians
                    }

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

                    Borrowedbooks.Columns["librarian_id"].HeaderText = "Librarian ID";
                    Borrowedbooks.Columns["name"].HeaderText = "Name";
                    Borrowedbooks.Columns["salary"].HeaderText = "Salary";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading librarians: " + ex.Message);
                }
            }
        }

        private void updateSal_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;password=fabian;database=library_management_system;";
            string librarianName = name.Text.Trim();
            string salaryInput = salary.Text.Trim();

            if (string.IsNullOrEmpty(librarianName) || string.IsNullOrEmpty(salaryInput))
            {
                MessageBox.Show("Please enter both name and salary.");
                return;
            }

            if (!decimal.TryParse(salaryInput, out decimal newSalary))
            {
                MessageBox.Show("Please enter a valid numeric salary.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Step 1: Get librarian_id and old salary
                    string selectQuery = "SELECT librarian_id, salary FROM librarians WHERE name = @name";
                    long librarianId = -1;
                    decimal oldSalary = 0;

                    using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@name", librarianName);
                        using (MySqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                librarianId = reader.GetInt32("librarian_id");
                                oldSalary = reader.GetDecimal("salary");
                            }
                            else
                            {
                                MessageBox.Show("Librarian not found.");
                                return;
                            }
                        }
                    }

                    // Step 2: Update salary
                    string updateQuery = "UPDATE librarians SET salary = @salary WHERE librarian_id = @librarian_id";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@salary", newSalary);
                        updateCmd.Parameters.AddWithValue("@librarian_id", librarianId);

                        int result = updateCmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            // Step 3: Log salary change
                            string logQuery = @"INSERT INTO salary_changes 
                                        (librarian_id, old_salary, new_salary, change_date)
                                        VALUES (@librarian_id, @old_salary, @new_salary, @change_date)";
                            using (MySqlCommand logCmd = new MySqlCommand(logQuery, conn))
                            {
                                logCmd.Parameters.AddWithValue("@librarian_id", librarianId);
                                logCmd.Parameters.AddWithValue("@old_salary", oldSalary);
                                logCmd.Parameters.AddWithValue("@new_salary", newSalary);
                                logCmd.Parameters.AddWithValue("@change_date", DateTime.Now);
                                logCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Salary updated and logged successfully!");
                            LoadLibrarians(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to update salary.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating salary: " + ex.Message);
                }
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            Reserve myLogin = new Reserve();
            myLogin.Show();
            this.Hide();
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

        

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void salary_TextChanged(object sender, EventArgs e)
        {

        }


        private void innerborrow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Borrowedbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
