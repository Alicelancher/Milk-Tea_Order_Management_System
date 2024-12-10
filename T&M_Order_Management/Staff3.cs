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
    public partial class Staff3 : Form
    {
        string OLDPASS = "";
        public Staff3()
        {
            InitializeComponent();
            getpass();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void getpass()
        {
            Dao dao = new Dao();
            string sql = $"select SPASS from STAFF where SNO = '{Data.UID}'";
            IDataReader dc = dao.read(sql);
            dc.Read();
            OLDPASS = dc[0].ToString();
            OLDPASS = OLDPASS.TrimEnd();
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == OLDPASS && textBox2.Text != "")
            {
                string sql = $"update STAFF set SPASS = '{textBox2.Text.TrimEnd()}' where SNO = '{Data.UID}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 0)
                {
                    MessageBox.Show("Success!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Failure!");
            }
        }
    }
}
