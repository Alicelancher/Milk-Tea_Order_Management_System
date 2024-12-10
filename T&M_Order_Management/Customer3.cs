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
    public partial class Customer3 : Form
    {
        public Customer3()
        {
            InitializeComponent();
            In_Show();
        }

        public void In_Show()//从数据库读取数据显示在表格控件中
        {
            Dao dao = new Dao();
            string sql = $"select CNAME,CTEL,CSITE,CPASS from CUSTOMER where CNO = '{Data.UID}'";
            IDataReader dc = dao.read(sql);
            dc.Read();
            textBoxNAME.Text = dc[0].ToString();
            textBoxTEL.Text = dc[1].ToString();
            textBoxSITE.Text = dc[2].ToString();
            textBoxPASS.Text = dc[3].ToString();
            dc.Close();
            dao.DaoClose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update CUSTOMER set CNAME = '{textBoxNAME.Text.TrimEnd()}', CTEL = '{textBoxTEL.Text.TrimEnd()}'," +
                $" CSITE = '{textBoxSITE.Text.TrimEnd()}', CPASS = '{textBoxPASS.Text.TrimEnd()}' where CNO = '{Data.UID}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("Success!");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
