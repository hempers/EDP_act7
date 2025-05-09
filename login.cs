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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPass.Text.Trim();

            string conString = "server=localhost;uid=root;password=fabian;database=library_management_system;";
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @password";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        // Login successful
                        frmDashboard myform = new frmDashboard();
                        myform.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
        int nWidthEllipse, int nHeightEllipse
        );

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.BorderStyle = BorderStyle.None;
            txtPass.BorderStyle = BorderStyle.None;
            txtUsername.BackColor = Color.WhiteSmoke;
            txtPass.BackColor = Color.WhiteSmoke;

            // Allow height adjustment
            txtUsername.Multiline = true;
            txtPass.Multiline = true;

            // Set consistent height
            txtUsername.Height = 20;
            txtPass.Height = 20;

            panel1.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 10, 10));

}


        private void label5_Click(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            fogotpass myform = new fogotpass();
            myform.Show();
            this.Hide();
        }
    }
}
