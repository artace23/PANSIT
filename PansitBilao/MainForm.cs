using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansitBilao
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dineBtn_Click(object sender, EventArgs e)
        {

            DineIn dine = new DineIn();

            this.Close();
            dine.Show();

            dine.UpdateStatus("DINE IN");
        }

        private void takeBtn_Click(object sender, EventArgs e)
        {

            DineIn dine = new DineIn();

            this.Close();
            dine.Show();

            dine.UpdateStatus("TAKE OUT");
        }
    }
}
