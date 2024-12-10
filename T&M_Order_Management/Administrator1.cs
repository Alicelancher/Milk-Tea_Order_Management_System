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
    public partial class Administrator1 : Form
    {
        public Administrator1()
        {
            InitializeComponent();
            label3.Text = Data.UName;
        }

        private void 顾客管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrator21 adminstrator = new Administrator21();
            this.Hide();
            adminstrator.ShowDialog();
            this.Show();
        }
        
        private void 订单管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Administrator25 adminstrator = new Administrator25();
            this.Hide();
            adminstrator.ShowDialog();
            this.Show();
        }

        private void 奶茶管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrator22 adminstrator = new Administrator22();
            this.Hide();
            adminstrator.ShowDialog();
            this.Show();
        }

        private void 店员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrator23 adminstrator = new Administrator23();
            this.Hide();
            adminstrator.ShowDialog();
            this.Show();
        }

        private void 外卖员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrator24 adminstrator = new Administrator24();
            this.Hide();
            adminstrator.ShowDialog();
            this.Show();
        }
    }
}
