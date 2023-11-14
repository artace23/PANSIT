using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansitBilao
{
    public partial class COForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-TV64G129\\SQLEXPRESS;Initial Catalog=pansitBilao;Integrated Security=True";
        public COForm()
        {
            InitializeComponent();
        }

        public void SetCash(decimal cash)
        {
            cashLabel.Text = cash.ToString();
        }

        public void SetItemNo(string itemNo)
        {
            itemNoLabel.Text = itemNo.ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm main = new MainForm();
            main.Show();
        }

        private void COForm_Load(object sender, EventArgs e)
        {
            DataTable orderTable = new DataTable();
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM GetOrderDetails(@itemNo)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Assuming itemNoLabel.Text is the item number as a string
                    // Convert it to int before passing it as a parameter
                    command.Parameters.AddWithValue("@itemNo", int.Parse(itemNoLabel.Text));

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(orderTable);
                    }
                }
            }

            dataGridView1.DataSource = orderTable;

            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["TotalAmount"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["TotalAmount"].Value.ToString(), out decimal rowTotal))
                    {
                        totalAmount += rowTotal;
                    }
                }
            }

            if (decimal.TryParse(cashLabel.Text, out decimal cashAmount))
            {
                decimal change = totalAmount - cashAmount;
                totalLabel.Text = totalAmount.ToString();
                changeLabel.Text = change.ToString();
                dateLabel.Text = DateTime.Now.ToString();
            }

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printed Successfully!", "Done", MessageBoxButtons.OK);
        }
    }
}
