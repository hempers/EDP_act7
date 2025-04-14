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
    public partial class frmDashboard : Form
    {
        Timer timer = new Timer();

        public frmDashboard()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmDashboard_Load);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login myLogin = new Login();
            myLogin.Show();
            this.Hide();
        }

        private void btnReserve_Click_1(object sender, EventArgs e)
        {
            btnReserve.FlatStyle = FlatStyle.Flat;
            btnReserve.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // Set label font
            label3.Font = new Font("Century Gothic", 7, FontStyle.Regular);

            // Set initial time
            label3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Set up timer
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += (s, args) =>
            {
                label3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            };
            timer.Start();
        }


    }
}
