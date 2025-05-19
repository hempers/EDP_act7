using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml; // EPPlus
using System.IO;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;


namespace Activity7
{
    public partial class Generate_Report : Form
    {

        public Generate_Report()
        {
            InitializeComponent();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "Report.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Report");

                            // Add headers
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                                worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                            }

                            // Add data rows
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value?.ToString() ?? "";
                                }
                            }

                            worksheet.Columns().AdjustToContents();

                            workbook.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Export Successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error exporting data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadReportData(string query)
        {
            string connectionString = "server=localhost;uid=root;password=fabian;database=library_management_system;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data:\n" + ex.Message);
            }
        }



        private void Generate_Report_Load(object sender, EventArgs e)
        {
                        cmbReportType.Items.AddRange(new string[]
               {
                        "All Librarians",
                        "All Reserved Books",
                        "All Borrowed Books",
                        "Salary Changes"
               });
                        cmbReportType.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void forReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string selectedReport = cmbReportType.SelectedItem.ToString();
            string query = "";

            switch (selectedReport)
            {
                case "All Librarians":
                    query = "SELECT librarian_id, name, salary FROM librarians";
                    break;

                case "All Reserved Books":
                    query = @"SELECT b.book_id, b.title AS book_title, u.name AS user_name, 
                            r.reservation_date, r.status
                      FROM books b
                      JOIN reservations r ON b.book_id = r.book_id
                      JOIN users u ON r.user_id = u.user_id
                      WHERE b.status = 'reserved'";
                    break;


                case "All Borrowed Books":
                    query = @"SELECT b.borrow_id AS borrow_id, u.name AS user_name, bk.title AS book_title, 
                             b.borrow_date, b.return_date, b.status
                      FROM borrowedbooks b
                      JOIN users u ON b.user_id = u.user_id
                      JOIN books bk ON b.book_id = bk.book_id
                      WHERE bk.status = 'borrowed'";
                    break;

                case "Salary Changes":
                    query = @"SELECT sc.change_id, l.name AS librarian_name, sc.old_salary, 
                             sc.new_salary, sc.change_date
                      FROM salary_changes sc
                      JOIN librarians l ON sc.librarian_id = l.librarian_id";
                    break;

                case "All Available Books":
                    query = @"SELECT book_id, title, status
                      FROM books
                      WHERE status = 'available'";
                    break;


                default:
                    MessageBox.Show("Invalid report type selected.");
                    return;
            }

            // Load data into DataTable
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;password=fabian;database=library_management_system;"))
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
            }

            // Show the results in a DataGridView or any output method
            // Example:
            // dataGridView1.DataSource = dt;
        


            dataGridView1.DataSource = dt;

            // Styling and formatting
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Bold);

            dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridView1.DefaultCellStyle.ForeColor = Color.DimGray;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Dynamically rename column headers if they exist
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                switch (column.Name)
                {
                    case "borrow_id":
                        column.HeaderText = "Borrow ID";
                        break;
                    case "user_name":
                        column.HeaderText = "User";
                        break;
                    case "book_title":
                        column.HeaderText = "Book Title";
                        break;
                    case "borrow_date":
                        column.HeaderText = "Borrow Date";
                        break;
                    case "return_date":
                        column.HeaderText = "Return Date";
                        break;
                    case "reservation_id":
                        column.HeaderText = "Reservation ID";
                        break;
                    case "status":
                        column.HeaderText = "Status";
                        break;
                    case "librarian_id":
                        column.HeaderText = "Librarian ID";
                        break;
                    case "name":
                        column.HeaderText = "Librarian Name";
                        break;
                    case "salary":
                        column.HeaderText = "Salary";
                        break;
                    case "change_id":
                        column.HeaderText = "Change ID";
                        break;
                    case "old_salary":
                        column.HeaderText = "Old Salary";
                        break;
                    case "new_salary":
                        column.HeaderText = "New Salary";
                        break;
                    case "change_date":
                        column.HeaderText = "Change Date";
                        break;
                }
            }
        }



       

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbReportType.Items.AddRange(new string[]
               {
                        "All Librarians",
                        "All Reserved Books",
                        "All Borrowed Books",
                        "All Available Books",
                        "Salary Changes"
               });
        }
    }
}
