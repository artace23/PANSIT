using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansitBilao
{
    public partial class AdminForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-TV64G129\\SQLEXPRESS;Initial Catalog=pansitBilao;Integrated Security=True";
        public AdminForm()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string storedProcedureName = "GetOrderDetailsWithReports";

                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Assuming itemNoLabel.Text is the item number as a string
                    // Convert it to int before passing it as a parameter
                    command.Parameters.AddWithValue("@itemNo", int.Parse(searchTextBox.Text));

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Create a DataTable to hold the data
                        DataTable orderTable = new DataTable();

                        // Use the Fill method to populate the DataTable
                        adapter.Fill(orderTable);

                        // Set the DataGridView's DataSource to the filled DataTable
                        dataGridView1.DataSource = orderTable;
                    }
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Clear();
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    // Check the column name used for 'itemNo', it should match the actual column name.
                    string itemNo = selectedRow.Cells["itemNo"].Value.ToString();
                    int custId = int.Parse(selectedRow.Cells["custId"].Value.ToString());
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("GetOrderDetailsWithReportsAndBilling", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@itemNo", itemNo);
                            command.Parameters.AddWithValue("@custId", custId);
                            SqlDataReader reader = command.ExecuteReader();
                            itemNoLabel.Text = itemNo;
                            while (reader.Read())
                            {
                                dateLabel.Text = reader["orderDate"].ToString();

                                decimal qty = Convert.ToDecimal(reader["Qty"]);
                                decimal price = Convert.ToDecimal(reader["price"]);
                                decimal totalAmount = qty * price;
                                // Clear existing rows in dataGridView2 before populating.
                                dataGridView2.Rows.Clear();
                                dataGridView2.Rows.Add(reader["Qty"].ToString(), reader["itemName"].ToString(), reader["price"].ToString(), totalAmount.ToString());

                                int total = 0;

                                foreach (DataGridViewRow row in dataGridView2.Rows)
                                {
                                    if (int.TryParse(row.Cells["total"].Value.ToString(), out int value))
                                    {
                                        total += value;
                                    }
                                }

                                totalLabel.Text = total.ToString();
                                cashLabel.Text = reader["cash"].ToString();

                                int sum = Convert.ToInt32(cashLabel.Text) - total;
                                changeLabel.Text = sum.ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
