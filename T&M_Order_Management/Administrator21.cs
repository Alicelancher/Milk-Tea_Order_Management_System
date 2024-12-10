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
    public partial class Administrator21 : Form
    {
        public Administrator21()
        {
            InitializeComponent();
        }

        private void Administrator21_Load(object sender, EventArgs e)
        {
            Table();
            if (dataGridView1.RowCount > 0)
            {
                label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//输出顾客名称
            }
        }

        public void Table()//从数据库读取数据显示在表格控件中
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select CNO,CNAME,CSITE,CTEL from CUSTOMER";
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
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string sql = $"update CUSTOMER set CPASS = '{ID}' where CNO = '{ID}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("Success!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取顾客编号
                DialogResult dr = MessageBox.Show("Confirm deletion?", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from CUSTOMER where CNO = '{id}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("Success!");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("Failure!");
                    }
                    dao.DaoClose();
                }
                Table();
            }
            catch
            {
                MessageBox.Show("Please select the customer to be deleted in the form first!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//输出顾客名称
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
