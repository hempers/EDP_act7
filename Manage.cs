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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadTableToGrid("users", dataGridView1);
           

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            int rowHeight = dataGridView1.RowTemplate.Height;
            int rowCount = dataGridView1.Rows.Count;
            int headerHeight = dataGridView1.ColumnHeadersHeight;

            int totalHeight = (rowCount * rowHeight) + headerHeight + 10;
            dataGridView1.Height = totalHeight;

            int totalWidth = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                totalWidth += col.Width;
            }
            dataGridView1.Width = totalWidth + 20;

            // Make grid view-only
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // Styling for clean appearance
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.EnableHeadersVisualStyles = false;

            // Optional: Customize column header style
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);

            // Optional: Customize row style
            dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            dataGridView1.DefaultCellStyle.ForeColor = Color.DimGray;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView1.Columns["user_id"].HeaderText = "User ID";
            dataGridView1.Columns["name"].HeaderText = "Name";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["status"].HeaderText = "Status";
            

            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Paint += panel1_Paint;
         
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Honeydew; // example color
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.DimGray;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadTableToGrid(string tableName, DataGridView grid)
        {
            string conString = "server=localhost;uid=root;password=fabian;database=library_management_system;";
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();

                // Select only specific columns
                string query = $"SELECT user_id, name, email, status FROM {tableName}";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                grid.DataSource = dt;
                reader.Close();

                AddActionButtons();
            }
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard myform = new frmDashboard();
            myform.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnMng_Click(object sender, EventArgs e)
        {
            Manage myform = new Manage();
            myform.Show();
            this.Hide();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (!dataGridView1.Columns.Contains("View") || !dataGridView1.Columns.Contains("Delete"))
                return;

            string headerText = "Action";

            // Get left-most and right-most button column header rectangles
            Rectangle r1 = dataGridView1.GetCellDisplayRectangle(dataGridView1.Columns["View"].Index, -1, true);
            Rectangle r2 = dataGridView1.GetCellDisplayRectangle(dataGridView1.Columns["Delete"].Index, -1, true);

            Rectangle mergedHeader = new Rectangle(r1.Left, r1.Top, r2.Right - r1.Left, r1.Height);

            using (SolidBrush backColorBrush = new SolidBrush(Color.DimGray))
                e.Graphics.FillRectangle(backColorBrush, mergedHeader);

            using (SolidBrush textBrush = new SolidBrush(Color.White))
            using (StringFormat format = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                e.Graphics.DrawString(headerText, new Font("Century Gothic", 10, FontStyle.Bold), textBrush, mergedHeader, format);

        }



    
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
            {
                // Ignore clicks on the header row
                if (e.RowIndex < 0)
                    return;

                // Get the name of the clicked column
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "View")
                {
                    // Retrieve user_id from the selected row
                    string selectedUserId = dataGridView1.Rows[e.RowIndex].Cells["user_id"].Value.ToString();

                    // Open the UserView form with the selected user_id
                    UserView userViewForm = new UserView(selectedUserId);
                    userViewForm.Show();
                }

                else if (columnName == "Delete")
                {
                    // Retrieve user_id from the selected row
                    string selectedUserId = dataGridView1.Rows[e.RowIndex].Cells["user_id"].Value.ToString();

                    // Open the DeleteUser form with the selected user_id
                    DeleteUser deleteUserForm = new DeleteUser(selectedUserId);
                    deleteUserForm.Show();
                    this.Hide();  // Optionally hide the Manage form
                }
        }

        

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddActionButtons()
        {
            // Only include "View" and "Delete"
            string[] actions = { "View", "Delete" };

            // Remove existing buttons if they exist
            foreach (string action in actions)
            {
                if (dataGridView1.Columns.Contains(action))
                    dataGridView1.Columns.Remove(action);
            }

            // Add View and Delete buttons
            foreach (string action in actions)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = action;
                buttonColumn.HeaderText = ""; // Hide individual sub-headers
                buttonColumn.Text = action;
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(buttonColumn);
            }
        }

        private void adduser_Click(object sender, EventArgs e)
        {

        }

        private void createuser_Click(object sender, EventArgs e)
        {
            // Open the DeleteUser form with the selected user_id
            CreateUser myForm = new CreateUser();
            myForm.Show();
            this.Hide();
        }

        private void btnMng_Click_1(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMngLib_Click(object sender, EventArgs e)
        {
            ManageLibrary myform = new ManageLibrary();
            myform.Show();
            this.Hide();
        }
    }

}

