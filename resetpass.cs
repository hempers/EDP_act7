using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity7
{
    public partial class resetpass : Form
    {
        private TextBox email; // Explicitly declare the field
        private TextBox reenterPass; // Renamed to avoid ambiguity

        public resetpass()
        {
            InitializeComponent();
            this.email = new System.Windows.Forms.TextBox();
            this.reenterPass = new System.Windows.Forms.TextBox(); // Updated field name
            this.email.PasswordChar = '*';
            this.reenterPass.PasswordChar = '*'; // Updated field name
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
            string newPassword = email.Text.Trim();
            string confirmPassword = reenterPass.Text.Trim(); // Updated field name

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in both password fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Password confirmed — proceed
            MessageBox.Show("Password successfully reset!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetsuccess resetForm = new resetsuccess();
            resetForm.Show();
            this.Hide();
        }
    }
}
