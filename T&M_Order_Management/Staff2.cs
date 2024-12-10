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
    public partial class Staff2 : Form
    {
        public Staff2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" && textBoxINGRE.Text != "" && textBoxNAME.Text != "" && textBoxPRICE.Text != "")
            {
                Dao dao = new Dao();
                string sql = $"insert into TEA values('{textBoxINGRE.Text.TrimEnd()}','{textBoxNAME.Text.TrimEnd()}','{textBoxID.Text.TrimEnd()}','{textBoxPRICE.Text.TrimEnd()}')";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("Success!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failure!");
                }
            }
            else
            {
                MessageBox.Show("Input not allowed to be empty!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
