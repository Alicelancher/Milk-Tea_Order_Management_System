namespace Milk_Tea_Order_Management
{
    partial class Administrator1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.顾客管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.奶茶管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顾客管理ToolStripMenuItem,
            this.奶茶管理ToolStripMenuItem,
            this.员工管理ToolStripMenuItem,
            this.订单管理ToolStripMenuItem,
            this.订单管理ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 顾客管理ToolStripMenuItem
            // 
            this.顾客管理ToolStripMenuItem.Name = "顾客管理ToolStripMenuItem";
            this.顾客管理ToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.顾客管理ToolStripMenuItem.Text = "Customer";
            this.顾客管理ToolStripMenuItem.Click += new System.EventHandler(this.顾客管理ToolStripMenuItem_Click);
            // 
            // 奶茶管理ToolStripMenuItem
            // 
            this.奶茶管理ToolStripMenuItem.Name = "奶茶管理ToolStripMenuItem";
            this.奶茶管理ToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.奶茶管理ToolStripMenuItem.Text = "Milk Tea";
            this.奶茶管理ToolStripMenuItem.Click += new System.EventHandler(this.奶茶管理ToolStripMenuItem_Click);
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.员工管理ToolStripMenuItem.Text = "Staff";
            this.员工管理ToolStripMenuItem.Click += new System.EventHandler(this.店员管理ToolStripMenuItem_Click);
            // 
            // 订单管理ToolStripMenuItem
            // 
            this.订单管理ToolStripMenuItem.Name = "订单管理ToolStripMenuItem";
            this.订单管理ToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.订单管理ToolStripMenuItem.Text = "Deliverer";
            this.订单管理ToolStripMenuItem.Click += new System.EventHandler(this.外卖员管理ToolStripMenuItem_Click);
            // 
            // 订单管理ToolStripMenuItem1
            // 
            this.订单管理ToolStripMenuItem1.Name = "订单管理ToolStripMenuItem1";
            this.订单管理ToolStripMenuItem1.Size = new System.Drawing.Size(66, 24);
            this.订单管理ToolStripMenuItem1.Text = "Order";
            this.订单管理ToolStripMenuItem1.Click += new System.EventHandler(this.订单管理ToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(78, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, administrator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dear:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(150, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 30);
            this.label3.TabIndex = 3;
            // 
            // Administrator1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrator1";
            this.Text = "Administrator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 顾客管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 奶茶管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单管理ToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}