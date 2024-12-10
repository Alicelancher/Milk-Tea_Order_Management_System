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
    public partial class Register3 : Form
    {
        public Register3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "" && textBoxPASS.Text != "" && textBoxNAME.Text != "" && textBoxTEL.Text != "" && textBoxTEMP.Text != "")
            {
                Dao dao = new Dao();
                string sql = $"insert into DELIVERER values('{textBoxNAME.Text.TrimEnd()}','{textBoxID.Text.TrimEnd()}','{textBoxPASS.Text.TrimEnd()}','{textBoxTEL.Text.TrimEnd()}','{textBoxTEMP.Text.TrimEnd()}')";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("Successful registration!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration failed!");
                }
            }
            else
            {
                MessageBox.Show("Inputs are not allowed to be empty!");
            }
        }
    }
}
