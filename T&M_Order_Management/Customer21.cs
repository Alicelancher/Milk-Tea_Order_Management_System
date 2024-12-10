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
    public partial class Customer21 : Form
    {
        string ID = "";
        public Customer21()
        {
            InitializeComponent();
        }
        public Customer21(string id, string name, string price)
        {
            InitializeComponent();
            Dao dao = new Dao();
            string sql = $"select CTEL, CSITE from CUSTOMER where CNO = '{Data.UID}'";
            IDataReader dc = dao.read(sql);
            dc.Read();
            label2.Text = Data.UName;
            label3.Text = dc[1].ToString();
            label5.Text = dc[0].ToString();
            ID = id;
            label7.Text = name;
            label9.Text = price;
            dc.Close();
            dao.DaoClose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string sql;

            sql = "select top 1 STAFF.SNO from ORDERS right outer join STAFF on ORDERS.SNO = STAFF.SNO where OSTATUS = '1' or OSTATUS is NULL group by STAFF.SNO order by count(*);";
            IDataReader d = dao.read(sql);
            string SID = "";
            if (d.Read())
            {
                SID = d[0].ToString();
            }
            else
            {
                SID = "S001";
            }

            sql = "select top 1 DELIVERER.DNO from ORDERS right outer join DELIVERER on ORDERS.DNO = DELIVERER.DNO where OSTATUS = '2'or OSTATUS is NULL group by DELIVERER.DNO order by count(*);";
            d = dao.read(sql);
            string DID = "";
            if (d.Read())
            {
                DID = d[0].ToString();
            }
            else
            {
                DID = "D001";
            }
            
            string PAY = "";
            if (radioButtonW.Checked == true)
            {
                PAY = "Wechat";
            }
            else
            {
                PAY = "Alipay";
            }
            sql = $"insert into ORDERS values ('{Data.UID}','{SID.TrimEnd()}','{DID.TrimEnd()}','{ID.TrimEnd()}','{textBox1.Text.TrimEnd()}','{PAY}','{label9.Text.TrimEnd()}','1',GETDATE())";
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
    }
}
