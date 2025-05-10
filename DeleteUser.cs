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
    public partial class DeleteUser : Form
    {
        private string selectedUserId;

        // Constructor to accept user ID for deletion
        public DeleteUser(string userId)
        {
            InitializeComponent();
            selectedUserId = userId;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            // Connection string
            string conString = "server=localhost;uid=root;password=fabian;database=library_management_system;";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();

                    // SQL DELETE query to delete the user based on their user_id
                    string query = "DELETE FROM users WHERE user_id = @userId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", selectedUserId);

                        int result = cmd.ExecuteNonQuery(); // Execute the query

                        if (result > 0)
                        {
                            MessageBox.Show("User deleted successfully.");
                            Manage myform = new Manage(); // Redirect back to Manage form
                            myform.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the user.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Manage myform = new Manage(); // <- pass the ID here
            myform.Show();
            this.Hide();
        }
    }
}
