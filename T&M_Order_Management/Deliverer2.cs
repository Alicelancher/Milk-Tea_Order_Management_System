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
    public partial class Deliverer2 : Form
    {
        string OLDPASS = "";
        public Deliverer2()
        {
            InitializeComponent();
            getpass();
        }

        public void getpass()
        {
            Dao dao = new Dao();
            string sql = $"select DPASS from DELIVERER where DNO = '{Data.UID}'";
            IDataReader dc = dao.read(sql);
            dc.Read();
            OLDPASS = dc[0].ToString();
            OLDPASS = OLDPASS.TrimEnd();
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.TrimEnd() == OLDPASS && textBox2.Text != "")
            {
                string sql = $"update DELIVERER set DPASS = '{textBox2.Text.TrimEnd()}' where DNO = '{Data.UID}'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
