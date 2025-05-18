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
    public partial class Reserve : Form
    {
        public Reserve()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bookReserve_Click(object sender, EventArgs e)
        {

        }

        private void btnborrow_Click(object sender, EventArgs e)
        {
            Transactions myLogin = new Transactions();
            myLogin.Show();
            this.Hide();
        }

        private void btnLibrarian_Click(object sender, EventArgs e)
        {
            LIbrarian myLogin = new LIbrarian();
            myLogin.Show();
            this.Hide();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            Reserve myLogin = new Reserve();
            myLogin.Show();
            this.Hide();
        }
    }
}
