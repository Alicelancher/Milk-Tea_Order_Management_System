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
    public partial class Staff1 : Form
    {
        public Staff1()
        {
            InitializeComponent();
            Table();
        }

        public void Table()//从数据库读取数据显示在表格控件中
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = String.Format("select ONO,TNAME,TING,ONOTE from ORDERS, TEA where OSTATUS = 1 and SNO = '{0}' and ORDERS.TNO = TEA.TNO", Data.UID);
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff2 staff = new Staff2();
            this.Hide();
            staff.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取订单编号
            string sql = $"update ORDERS set OSTATUS = '2',OTIME = GETDATE() where ONO = '{id}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("Production is complete!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staff3 staff3 = new Staff3();
            staff3.ShowDialog();
        }
    }
}
