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
    public partial class ManageLibrary : Form
    {

        public ManageLibrary()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMng_Click(object sender, EventArgs e)
        {
            Manage myform = new Manage();
            myform.Show();
            this.Hide();
        }

        private void ManageLibrary_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDashboard myform = new frmDashboard();
            myform.Show();
            this.Hide();
        }
    }
}
