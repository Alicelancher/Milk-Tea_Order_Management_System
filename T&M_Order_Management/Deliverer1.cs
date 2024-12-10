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
    public partial class Deliverer1 : Form
    {
        public Deliverer1()
        {
            InitializeComponent();
            Table();
        }

        public void Table()//从数据库读取数据显示在表格控件中
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = String.Format("select ONO, CSITE, CTEL, ONOTE from ORDERS, CUSTOMER where OSTATUS = 2 and DNO = '{0}' and ORDERS.CNO = CUSTOMER.CNO", Data.UID);
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取订单编号
            string sql = $"update ORDERS set OSTATUS = '3',OTIME = GETDATE() where ONO = '{id}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("Success!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxTEMP.Text != "")
            {
                Dao dao = new Dao();
                string sql = $"update DELIVERER set DTEMP = '{textBoxTEMP.Text.TrimEnd()}' where DNO = '{Data.UID}'";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("Success!");
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

        private void button3_Click(object sender, EventArgs e)
        {
            Deliverer2 deliverer2 = new Deliverer2();
            this.Hide();
            deliverer2.ShowDialog();
            this.Show();
        }
    }
}
