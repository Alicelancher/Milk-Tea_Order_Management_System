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
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Login();
            }
            else
            {
                MessageBox.Show("Input is not legal, please input again!");
            }
        }
        public void Login()//登录方法，允许登录返回真
        {
            //顾客
            if (radioButton_Customer.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from CUSTOMER where CNO = '" + textBox1.Text + "' and CPASS = '" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {

                    //将登录用户信息存到当前
                    Data.UID = dc["CNO"].ToString();
                    Data.UName = dc["CNAME"].ToString();

                    MessageBox.Show("Log in successfully!");
                    Customer1 customer = new Customer1();
                    this.Hide();
                    customer.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }
                dao.DaoClose();
            }
            //店员
            if (radioButton_Staff.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from STAFF where SNO = '" + textBox1.Text + "' and SPASS = '" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {

                    //将登录用户信息存到当前
                    Data.UID = dc["SNO"].ToString();
                    Data.UName = dc["SNAME"].ToString();

                    MessageBox.Show("Log in successfully!");
                    Staff1 staff = new Staff1();
                    this.Hide();
                    staff.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }
                dao.DaoClose();
            }
            //外卖员
            if (radioButton_Deliverer.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from DELIVERER where DNO = '" + textBox1.Text + "' and DPASS = '" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {

                    //将登录用户信息存到当前
                    Data.UID = dc["DNO"].ToString();
                    Data.UName = dc["DNAME"].ToString();

                    MessageBox.Show("Log in successfully!");
                    Deliverer1 deliverer = new Deliverer1();
                    this.Hide();
                    deliverer.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }
                dao.DaoClose();
            }
            //管理员
            if (radioButton_ADMIN.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from ADMINISTRATOR where ANO = '" + textBox1.Text + "' and APASS = '" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {

                    //将登录用户信息存到当前
                    Data.UID = dc["ANO"].ToString();
                    Data.UName = dc["ANAME"].ToString();

                    MessageBox.Show("Log in successfully!");
                    Administrator1 adminstrator = new Administrator1();
                    this.Hide();
                    adminstrator.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }
                dao.DaoClose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }
    }
}
