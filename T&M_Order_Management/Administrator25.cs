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
    public partial class Administrator25 : Form
    {
        public Administrator25()
        {
            InitializeComponent();
            Table();
        }
        
        public void Table()//从数据库读取数据显示在表格控件中
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from ORDERS";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[4].ToString(), dc[5].ToString(), dc[7].ToString(),
                                       dc[6].ToString(), dc[2].ToString(), dc[3].ToString(), dc[8].ToString(), dc[9].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table();
        }
    }
}
