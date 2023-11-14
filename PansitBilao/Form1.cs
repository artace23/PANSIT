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
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=LAPTOP-TV64G129\\SQLEXPRESS;Initial Catalog=pansitBilao;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM dbo.GetEmployeeCredentials(@username, @password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", user);
                        command.Parameters.AddWithValue("@password", pass);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedUser = reader["Username"].ToString();
                                string storedPass = reader["Password"].ToString();
                                string role = reader["Role"].ToString();

                                if (user == storedUser && pass == storedPass)
                                {
                                    // Successful login
                                    if (role == "staff")
                                    {
                                        this.Hide();
                                        MainForm mainForm = new MainForm();
                                        mainForm.Show();
                                    }
                                    else if (role == "admin")
                                    {
                                        this.Hide();
                                        AdminForm admin = new AdminForm();
                                        admin.Show();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid username or password. Please try again.");
                                    username.Text = "";
                                    password.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password. Please try again.");
                                username.Text = "";
                                password.Text = "";
                            }
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
