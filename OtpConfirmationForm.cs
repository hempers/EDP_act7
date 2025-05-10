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
using Mysqlx.Session;

namespace Activity7
{
    public partial class OtpConfirmationForm : Form
    {

        public OtpConfirmationForm(string otpCode, string email)
        {
            InitializeComponent();
            expectedOtp = otpCode;
            userEmail = email;
        }

        private void forgotpass_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Login myform = new Login();
            myform.Show();
            this.Hide();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string enteredOtp = OTP.Text.Trim();

            if (enteredOtp == expectedOtp)
            {
                MessageBox.Show("OTP verified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int admin_id = GetAdminIdByEmail(userEmail); // 👈 get the Admin_id from DB

                if (admin_id != -1)
                {
                    resetpass resetForm = new resetpass(admin_id);
                    resetForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Admin ID not found for this email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetAdminIdByEmail(string email)
        {
            string connectionString = "server=localhost;uid=root;password=fabian;database=library_management_system;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT admin_id FROM admin WHERE Email = @Email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int admin_id))
                        {
                            return admin_id;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return -1; // not found or error
        }



        private void OTP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
