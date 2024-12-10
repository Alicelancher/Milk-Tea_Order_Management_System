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
    public partial class Administrator222 : Form
    {
        string ID = "";
        public Administrator222()
        {
            InitializeComponent();
        }
        public Administrator222(string id, string name, string ingre, string price)
        {
            InitializeComponent();
            ID = textBoxID.Text = id;
            textBoxNAME.Text = name;
            textBoxINGRE.Text = ingre;
            textBoxPRICE.Text = price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update TEA set TNO = '{textBoxID.Text.TrimEnd()}', TNAME = '{textBoxNAME.Text.TrimEnd()}'," +
                $" TING = '{textBoxINGRE.Text.TrimEnd()}', TP = '{textBoxPRICE.Text.TrimEnd()}' where TNO = '{ID}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("Success!");
                this.Close();
            }
        }
    }
}
