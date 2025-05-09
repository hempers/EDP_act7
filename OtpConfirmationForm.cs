using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            string enteredOtp = OTP.Text.Trim(); // assumes OTP is the name of your TextBox

            if (enteredOtp == expectedOtp)
            {
                MessageBox.Show("OTP verified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Example: proceed to reset password form
                resetpass resetForm = new resetpass();
                resetForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OTP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
