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
    public partial class EditUser : Form
    {
        private string selectedUserId;
        public EditUser(string userId)
        {
            InitializeComponent();
            
            selectedUserId = userId;

            txtUserId.Text = userId;
            txtUserId.Enabled = false;

            LoadUserInfo();
        }

        public EditUser()
        {
        }

        private void LoadUserInfo()
        {
            string conString = "server=localhost;uid=root;password=fabian;database=library_management_system;";
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();
                string query = "SELECT user_id, name, email, phone, address, status FROM users WHERE user_id = @userId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", selectedUserId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtUserId.Text = reader["user_id"].ToString();
                            name.Text = reader["name"].ToString();
                            email.Text = reader["email"].ToString();
                            phonenumber.Text = reader["phone"].ToString();
                            address.Text = reader["address"].ToString();
                            status.Text = reader["status"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }
            }
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
           
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            UserView myform = new UserView(selectedUserId);
            myform.Show();
            this.Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
            // Validate the fields (optional)
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(phonenumber.Text) || string.IsNullOrEmpty(address.Text) || string.IsNullOrEmpty(status.Text))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }

            // Connect to the database and update user information
            string conString = "server=localhost;uid=root;password=fabian;database=library_management_system;";
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE users SET name = @name, email = @email, phone = @phone, address = @address, status = @status WHERE user_id = @userId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters with the values from the form
                        cmd.Parameters.AddWithValue("@userId", selectedUserId);
                        cmd.Parameters.AddWithValue("@name", name.Text);
                        cmd.Parameters.AddWithValue("@email", email.Text);
                        cmd.Parameters.AddWithValue("@phone", phonenumber.Text);
                        cmd.Parameters.AddWithValue("@address", address.Text);
                        cmd.Parameters.AddWithValue("@status", status.Text);

                        // Execute the update query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User information updated successfully.");
                            Manage myform = new Manage(); // Pass the userId to load updated info
                            myform.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
