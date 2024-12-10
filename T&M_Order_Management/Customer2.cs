﻿using System;
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
    public partial class Customer2 : Form
    {
        public Customer2()
        {
            InitializeComponent();
        }

        private void Customer2_Load(object sender, EventArgs e)
        {
            Table();
            if (dataGridView1.RowCount > 0)
            {
                label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//输出奶茶名称
            }
        }

        public void Table()//从数据库读取数据显示在表格控件中
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select TNO,TNAME,TING,TP from TEA";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        public void TableID()//根据编号从数据库读取数据显示在表格控件中
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select TNO,TNAME,TING,TP from TEA where TNO = '{textBox1.Text}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        public void TableNAME()//根据名称从数据库读取数据显示在表格控件中
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select TNO,TNAME,TING,TP from TEA where TNAME LIKE '%{textBox2.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableID();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TableNAME();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取奶茶编号
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//获取奶茶名称
                string price = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();//获取奶茶价格
                Customer21 customer = new Customer21(id, name, price);
                this.Hide();
                customer.ShowDialog();
                this.Show();
            //}
            //catch
            //{
            //    MessageBox.Show("ERROR!");
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//输出奶茶名称
            }
        }

        private void Customer2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//输出奶茶名称
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                label2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//输出奶茶名称
            }
        }
    }
}