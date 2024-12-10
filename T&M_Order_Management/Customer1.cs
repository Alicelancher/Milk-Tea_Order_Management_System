using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milk_Tea_Order_Management
{
    public partial class Customer1 : Form
    {
        public Customer1()
        {
            InitializeComponent();
            label3.Text = Data.UName;
        }

        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer2 c = new Customer2();
            this.Hide();
            c.ShowDialog();
            this.Show();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email：ziqguo3-c@cityu.edu.hk", "Help");
        }

        private void InformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer3 customer = new Customer3();
            this.Hide();
            customer.ShowDialog();
            this.Show();
        }
    }
}
