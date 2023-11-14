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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PansitBilao
{
    
    public partial class AddForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-TV64G129\\SQLEXPRESS;Initial Catalog=pansitBilao;Integrated Security=True";
        private DineIn dineForm;
        public AddForm(DineIn dine)
        {
            InitializeComponent();
            dineForm = dine;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string data1 = itemNo.Text; 
            string data2 = orderName.Text;
            string data3 = qty.Text;
            string data4 = price.Text;

            dineForm.AddDataToDataGridView(data1, data2, data3, data4);
            this.Hide();
        }

        private void itemNo_TextChanged(object sender, EventArgs e)
        {
            // Get the entered item number from the TextBox
            int itemNumber;

            if (int.TryParse(itemNo.Text, out itemNumber))
            {
                // Call the method to perform the database query
                GetItemDetails(itemNumber);
            }
            else
            {
                // Handle invalid input, e.g., show a message to the user
            }
        }
        private void GetItemDetails(int itemNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Item WHERE itemNo = @ItemNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter to the query
                        command.Parameters.AddWithValue("@ItemNumber", itemNumber);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                orderName.Text = reader[1].ToString();
                                price.Text = reader[2].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log, show an error message)
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
