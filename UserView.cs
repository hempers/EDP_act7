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
    public partial class UserView : Form
    {
        private string selectedUserId;

        public UserView(string userId)
        {
            InitializeComponent();
            selectedUserId = userId;

            txtUserId.Text = userId;
            txtUserId.Enabled = false; // Disable user_id field from editing
            LoadUserInfo();

            // Disable all other fields from editing (view-only mode)
            name.Enabled = false;
            email.Enabled = false;
            phonenumber.Enabled = false;
            address.Enabled = false;
            status.Enabled = false;

            // Optionally, you can also change the back color to make them look like static fields
            name.BackColor = Color.White;
            email.BackColor = Color.White;
            phonenumber.BackColor = Color.White;
            address.BackColor = Color.White;
            status.BackColor = Color.White;

            // Hover effect for the back button
            back.MouseEnter += back_MouseEnter;
            back.MouseLeave += back_MouseLeave;
        }

        public UserView()
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
        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Manage myform = new Manage();
            myform.Show();
            this.Hide();
        }


        private void back_MouseEnter(object sender, EventArgs e)
        {
            back.BackColor = Color.MintCream;
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            back.BackColor = Color.White;
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
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

        private void edit_Click(object sender, EventArgs e)
        {
            EditUser myform = new EditUser(selectedUserId); // <- pass the ID here
            myform.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

 