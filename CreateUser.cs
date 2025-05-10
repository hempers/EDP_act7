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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string conString = "server=localhost;uid=root;password=fabian;database=library_management_system;";

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO users (name, email, address, phone, status) " +
                                   "VALUES (@name, @email, @address, @phone, @status)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@address", address.Text);
                    cmd.Parameters.AddWithValue("@phone", phonenumber.Text);
                    cmd.Parameters.AddWithValue("@status", status.Text);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Manage manageForm = new Manage();
                        manageForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            frmDashboard myForm = new frmDashboard();
            myForm.Show();
            this.Hide();
        }

        private void phonenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
