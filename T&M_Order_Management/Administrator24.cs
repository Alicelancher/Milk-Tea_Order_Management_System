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
    public partial class Administrator24 : Form
    {
        public Administrator24()
        {
            InitializeComponent();
        }

        private void Administrator24_Load(object sender, EventArgs e)
        {
            Table();
            if (dataGridView1.RowCount > 0)
            {
                label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//输出店员名称
            }
        }
        public void Table()//从数据库读取数据显示在表格控件中
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select DNO,DNAME,DTEMP,DTEL from DELIVERER";
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
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取编号
                DialogResult dr = MessageBox.Show("Confirm deletion?", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from DELIVERER where DNO = '{id}'";
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
                MessageBox.Show("Please select the deliverer to be deleted in the form first!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string sql = $"update DELIVERER set DPASS = '{ID}' where DNO = '{ID}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("Success!");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//输出名称
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
