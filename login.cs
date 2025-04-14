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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmDashboard myform = new frmDashboard();
            myform.Show();
            this.Hide();
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
    }
}
