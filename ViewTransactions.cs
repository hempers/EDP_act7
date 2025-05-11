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
    public partial class ViewTransactions : Form
    {
        public ViewTransactions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDashboard myform = new frmDashboard();
            myform.Show();
            this.Hide();
        }

        private void btnMng_Click(object sender, EventArgs e)
        {
            Manage myform = new Manage();
            myform.Show();
            this.Hide();
        }

        private void btnMngLib_Click(object sender, EventArgs e)
        {
            ManageLibrary myform = new ManageLibrary();
            myform.Show();
            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Login myform = new Login();
            myform.Show();
            this.Hide();
        }
    }
}
