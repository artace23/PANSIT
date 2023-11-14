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
    public partial class DineIn : Form
    {
        private string connectionString = "Data Source=LAPTOP-TV64G129\\SQLEXPRESS;Initial Catalog=pansitBilao;Integrated Security=True";

        public DineIn()
        {
            InitializeComponent();
        }
        public void UpdateStatus(string newText)
        {
            status.Text = newText;
        }

        public void AddDataToDataGridView(string data1, string data2, string data3, string data4)
        {
            itemTable.Rows.Add(data1, data2, data3, data4);
            decimal total1 = 0;

            // Replace 2 with the actual index of the column you want to total
            int columnIndex = 3;

            foreach (DataGridViewRow row in itemTable.Rows)
            {
                if (row.Cells[columnIndex].Value != null)
                {
                    if (decimal.TryParse(row.Cells[columnIndex].Value.ToString(), out decimal cellValue) && int.TryParse(row.Cells[2].Value.ToString(), out int quantity))
                    {
                        total1 += cellValue * quantity;
                    }
                }
            }

            total.Text = total1.ToString();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm(this);
            add.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();

            this.Close();
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            string itemNo = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("InsertCustomerAndOrder", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (DataGridViewRow row in itemTable.Rows)
                    {
                        itemNo = row.Cells["itemNo"].Value.ToString();
                        command.Parameters.AddWithValue("@itemNo", row.Cells["itemNo"].Value);
                        command.Parameters.AddWithValue("@quantity", row.Cells["quantity"].Value);
                        command.Parameters.AddWithValue("@price", row.Cells["price"].Value);
                        command.Parameters.AddWithValue("@cash", cash.Text);
                        command.Parameters.AddWithValue("@employee", 1);

                        int rowsAffected = command.ExecuteNonQuery();

                    }
                }
            }

            decimal.TryParse(cash.Text, out decimal cashAmount);
            COForm cOForm = new COForm();
            cOForm.SetItemNo(itemNo);
            cOForm.SetCash(cashAmount);
            this.Close();
            cOForm.Show();
        }
    }
}
