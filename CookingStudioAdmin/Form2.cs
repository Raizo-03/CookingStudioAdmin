using CookingStudioAdmin.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using System.Xml;


namespace CookingStudioAdmin
{
    public partial class DashboardForm : Form
    {
        private DatabaseManager databaseManager;

        public DashboardForm()
        {
            InitializeComponent();
            //This code is for the form to be in the center position
            this.StartPosition = FormStartPosition.CenterScreen;

            databaseManager = new DatabaseManager("Server=localhost;Database=cookingstudio;Uid=root;Pwd='';"); // Replace "YourConnectionString" with your actual connection string
            
            //Makes the table not editable
            BookingGridView.ReadOnly = true;

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            //This is the instance of form when closing- it calls the method DashboardForm_FormClosing
            this.FormClosing += DashboardForm_FormClosing;

            //This code ensures that the form is not resizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Fetch bookings data
            DataTable bookingsTable = databaseManager.GetBookings();

            // Bind the data to the DataGridView
            BookingGridView.DataSource = bookingsTable;
        }
        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ensure that the application exits when the main form is closed
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If user confirms, proceed with logout
            if (result == DialogResult.Yes)
            {
                // Show the login form
                loginForm login = new loginForm();
                login.Show();

                // Close the current form
                this.Hide(); // or this.Hide(); if you want to hide instead of closing
            }
            // If user cancels, do nothing
        }


        private void downloadExcelButton_Click(object sender, EventArgs e)
        {
            if (BookingGridView == null || BookingGridView.Rows.Count == 0 || BookingGridView.Columns.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Creating Excel workbook
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Bookings");

                // Adding DataGridView data to Excel worksheet
                for (int i = 1; i <= BookingGridView.Columns.Count; i++)
                {
                    worksheet.Cell(1, i).Value = BookingGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < BookingGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < BookingGridView.Columns.Count; j++)
                    {
                        object cellValue = BookingGridView.Rows[i].Cells[j].Value;
                        worksheet.Cell(i + 2, j + 1).Value = cellValue != null ? cellValue.ToString() : "";
                    }
                }

                // Saving workbook to a MemoryStream
                using (MemoryStream stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var buffer = stream.ToArray();

                    // Prompting user to save the file
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveFileDialog.FileName = "Bookings.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Writing MemoryStream data to the file
                        File.WriteAllBytes(saveFileDialog.FileName, buffer);
                        MessageBox.Show("Excel file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void downloadXMLButton_Click(object sender, EventArgs e)
        {   // Create a DataTable to hold your data
            DataTable dataTable = new DataTable();
            // Assuming your DataGridView is named dataGridView1
            // You can replace dataGridView1 with the actual name of your DataGridView
            if (BookingGridView.DataSource is DataTable)
            {
                dataTable = (DataTable)BookingGridView.DataSource;
            }

            // Save the DataTable to XML
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog.Title = "Save XML File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(saveFileDialog.FileName))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Data");

                    foreach (DataRow row in dataTable.Rows)
                    {
                        xmlWriter.WriteStartElement("Row");
                        foreach (DataColumn col in dataTable.Columns)
                        {
                            xmlWriter.WriteElementString(col.ColumnName, Convert.ToString(row[col]));
                        }
                        xmlWriter.WriteEndElement(); // Row
                    }

                    xmlWriter.WriteEndElement(); // Data
                    xmlWriter.WriteEndDocument();
                }

                MessageBox.Show("XML file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void downloadTxtButton_Click(object sender, EventArgs e)
        {
            // Fetch data from the database
            DataTable dataTable = databaseManager.GetBookings();

            // Check if the DataTable contains any rows
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }

            // Specify the file extension and create a SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save Text File";

            // Show the SaveFileDialog
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a StreamWriter to write to the file
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    // Write column headers
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        streamWriter.Write(column.ColumnName + "\t");
                    }
                    streamWriter.WriteLine();

                    // Iterate over the rows of the DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Write row data
                        foreach (var item in row.ItemArray)
                        {
                            streamWriter.Write(item.ToString() + "\t");
                        }
                        streamWriter.WriteLine();
                    }
                }

                MessageBox.Show("Text file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void downloadCSVButton_Click(object sender, EventArgs e)
        {
            // Fetch data from the database
            DataTable dataTable = databaseManager.GetBookings();

            // Check if the DataTable contains any rows
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }

            // Specify the file extension and create a SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.Title = "Save CSV File";

            // Show the SaveFileDialog
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a StreamWriter to write to the file
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    // Write column headers
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        streamWriter.Write("\"" + column.ColumnName.Replace("\"", "\"\"") + "\",");
                    }
                    streamWriter.WriteLine();

                    // Iterate over the rows of the DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Write row data
                        foreach (var item in row.ItemArray)
                        {
                            streamWriter.Write("\"" + item.ToString().Replace("\"", "\"\"") + "\",");
                        }
                        streamWriter.WriteLine();
                    }
                }

                MessageBox.Show("CSV file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            // Fetch data from the database
            DataTable dataTable = databaseManager.GetBookings();

            // Check if the DataTable contains any rows
            if (dataTable.Rows.Count > 0)
            {
                // Bind the data to the DataGridView
                BookingGridView.DataSource = dataTable;
            }
            else
            {
                // If no data is available, display a message to the user
                MessageBox.Show("No bookings found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
