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
    public partial class resetsuccess : Form
    {
        public resetsuccess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login resetForm = new Login();
            resetForm.Show();
            this.Hide();
        }
    }
}
