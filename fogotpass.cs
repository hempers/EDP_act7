using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Activity7
{
    public partial class fogotpass : Form
    {
        public fogotpass()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fogotpass_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login myform = new Login();
            myform.Show();
            this.Hide();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string userEmail = Email.Text.Trim(); // your TextBox for email input

            if (string.IsNullOrEmpty(userEmail))
            {
                MessageBox.Show("Please enter your email.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string conString = "server=localhost;uid=root;password=fabian;database=library_management_system;";
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM admin WHERE email = @Email";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", userEmail);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Generate a random 6-digit code
                        Random rnd = new Random();
                        string verificationCode = rnd.Next(100000, 999999).ToString();

                        try
                        {
                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress("maeannebongat@gmail.com");
                            mail.To.Add(userEmail);
                            mail.Subject = "Password Reset Verification Code";
                            mail.Body = $"Your verification code is: {verificationCode}";

                            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                            {
                                EnableSsl = true, // Use SSL/TLS
                                DeliveryMethod = SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false
                            };

                            // Make sure credentials are set correctly
                            smtp.Credentials = new NetworkCredential("maeannebongat@gmail.com", "snoianubcxbtkvqh");

                            // Send the email
                            smtp.Send(mail);

                            // Open the OTP confirmation form and pass the code and email
                            OtpConfirmationForm otpForm = new OtpConfirmationForm(verificationCode, userEmail);
                            otpForm.Show();
                            this.Hide(); // Optional: hide current form

                            MessageBox.Show("Verification code sent! Please check your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // TODO: Store `verificationCode` temporarily to validate later (maybe in a variable, session, or a DB field)
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Email sending failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email not found in the system.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }




        private void Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
