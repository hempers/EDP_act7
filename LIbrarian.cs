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
    public partial class LIbrarian : Form
    {
        public LIbrarian()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            Reserve myLogin = new Reserve();
            myLogin.Show();
            this.Hide();
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
    }
}
