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
    public partial class resetpass : Form
    {
        private TextBox emailTextBox; // Renamed to avoid ambiguity  
        private TextBox reenterPassTextBox; // Renamed to avoid ambiguity  

        private int admin_id;
        public resetpass(int adminId)
        {
            InitializeComponent();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.reenterPassTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox.PasswordChar = '*';
            this.reenterPassTextBox.PasswordChar = '*';
            this.admin_id = adminId;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reenterpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirmreset_Click(object sender, EventArgs e)
        { 
            string newPassword = newPasswordTextBox.Text.Trim();
            string confirmPassword = confirmPasswordTextBox.Text.Trim();
           
            if  (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Replace this with your actual connection string
            string connectionString = "server=localhost;uid=root;password=fabian;database=library_management_system;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE admin SET Password = @Password WHERE admin_id = @admin_id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@admin_id", admin_id);



                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password successfully reset!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetsuccess resetForm = new resetsuccess();
                            resetForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Email not found. Please check your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void admin_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
