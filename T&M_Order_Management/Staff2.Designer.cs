﻿namespace Milk_Tea_Order_Management
{
    partial class Staff2
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
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxINGRE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPRICE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Location = new System.Drawing.Point(338, 120);
            this.textBoxNAME.Multiline = true;
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(201, 32);
            this.textBoxNAME.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(186, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tea Name";
            // 
            // textBoxINGRE
            // 
            this.textBoxINGRE.Location = new System.Drawing.Point(338, 188);
            this.textBoxINGRE.Multiline = true;
            this.textBoxINGRE.Name = "textBoxINGRE";
            this.textBoxINGRE.Size = new System.Drawing.Size(201, 32);
            this.textBoxINGRE.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(186, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingredient";
            // 
            // textBoxPRICE
            // 
            this.textBoxPRICE.Location = new System.Drawing.Point(338, 259);
            this.textBoxPRICE.Multiline = true;
            this.textBoxPRICE.Name = "textBoxPRICE";
            this.textBoxPRICE.Size = new System.Drawing.Size(201, 32);
            this.textBoxPRICE.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(186, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(166, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "New Production";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(462, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(338, 54);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(201, 32);
            this.textBoxID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(186, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tea ID";
            // 
            // Staff2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPRICE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxINGRE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNAME);
            this.Controls.Add(this.label2);
            this.Name = "Staff2";
            this.Text = "Create New Production";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxINGRE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPRICE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
    }
}