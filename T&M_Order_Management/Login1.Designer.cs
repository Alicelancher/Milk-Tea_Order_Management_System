using System;

namespace Milk_Tea_Order_Management
{
    partial class Login1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton_Customer = new System.Windows.Forms.RadioButton();
            this.radioButton_Staff = new System.Windows.Forms.RadioButton();
            this.radioButton_Deliverer = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton_ADMIN = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Milk and Tea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(207, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(194, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password：";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(313, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 34);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(313, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 34);
            this.textBox2.TabIndex = 4;
            // 
            // radioButton_Customer
            // 
            this.radioButton_Customer.AutoSize = true;
            this.radioButton_Customer.Checked = true;
            this.radioButton_Customer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_Customer.Location = new System.Drawing.Point(139, 266);
            this.radioButton_Customer.Name = "radioButton_Customer";
            this.radioButton_Customer.Size = new System.Drawing.Size(125, 31);
            this.radioButton_Customer.TabIndex = 5;
            this.radioButton_Customer.TabStop = true;
            this.radioButton_Customer.Text = "Customer";
            this.radioButton_Customer.UseVisualStyleBackColor = true;
            // 
            // radioButton_Staff
            // 
            this.radioButton_Staff.AutoSize = true;
            this.radioButton_Staff.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_Staff.Location = new System.Drawing.Point(300, 266);
            this.radioButton_Staff.Name = "radioButton_Staff";
            this.radioButton_Staff.Size = new System.Drawing.Size(77, 31);
            this.radioButton_Staff.TabIndex = 6;
            this.radioButton_Staff.TabStop = true;
            this.radioButton_Staff.Text = "Staff";
            this.radioButton_Staff.UseVisualStyleBackColor = true;
            // 
            // radioButton_Deliverer
            // 
            this.radioButton_Deliverer.AutoSize = true;
            this.radioButton_Deliverer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_Deliverer.Location = new System.Drawing.Point(420, 266);
            this.radioButton_Deliverer.Name = "radioButton_Deliverer";
            this.radioButton_Deliverer.Size = new System.Drawing.Size(118, 31);
            this.radioButton_Deliverer.TabIndex = 7;
            this.radioButton_Deliverer.TabStop = true;
            this.radioButton_Deliverer.Text = "Deliverer";
            this.radioButton_Deliverer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(174, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(518, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton_ADMIN
            // 
            this.radioButton_ADMIN.AutoSize = true;
            this.radioButton_ADMIN.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_ADMIN.Location = new System.Drawing.Point(561, 266);
            this.radioButton_ADMIN.Name = "radioButton_ADMIN";
            this.radioButton_ADMIN.Size = new System.Drawing.Size(164, 31);
            this.radioButton_ADMIN.TabIndex = 10;
            this.radioButton_ADMIN.TabStop = true;
            this.radioButton_ADMIN.Text = "Administrator";
            this.radioButton_ADMIN.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(346, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 45);
            this.button3.TabIndex = 11;
            this.button3.Text = "Register";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.radioButton_ADMIN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton_Deliverer);
            this.Controls.Add(this.radioButton_Staff);
            this.Controls.Add(this.radioButton_Customer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton_Customer;
        private System.Windows.Forms.RadioButton radioButton_Staff;
        private System.Windows.Forms.RadioButton radioButton_Deliverer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton_ADMIN;
        private System.Windows.Forms.Button button3;

        public EventHandler Login1_Load { get; private set; }
    }
}

