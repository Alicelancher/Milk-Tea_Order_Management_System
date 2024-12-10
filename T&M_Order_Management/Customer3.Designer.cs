namespace Milk_Tea_Order_Management
{
    partial class Customer3
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPASS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSITE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTEL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(238, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 47);
            this.button1.TabIndex = 28;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPASS
            // 
            this.textBoxPASS.Location = new System.Drawing.Point(368, 274);
            this.textBoxPASS.Name = "textBoxPASS";
            this.textBoxPASS.Size = new System.Drawing.Size(201, 25);
            this.textBoxPASS.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(232, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Password";
            // 
            // textBoxSITE
            // 
            this.textBoxSITE.Location = new System.Drawing.Point(368, 203);
            this.textBoxSITE.Name = "textBoxSITE";
            this.textBoxSITE.Size = new System.Drawing.Size(201, 25);
            this.textBoxSITE.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(232, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Address";
            // 
            // textBoxTEL
            // 
            this.textBoxTEL.Location = new System.Drawing.Point(368, 135);
            this.textBoxTEL.Name = "textBoxTEL";
            this.textBoxTEL.Size = new System.Drawing.Size(201, 25);
            this.textBoxTEL.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(232, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tel";
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Location = new System.Drawing.Point(368, 67);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(201, 25);
            this.textBoxNAME.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(232, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(417, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 47);
            this.button2.TabIndex = 29;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Customer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPASS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSITE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTEL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNAME);
            this.Controls.Add(this.label1);
            this.Name = "Customer3";
            this.Text = "Infromation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPASS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSITE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTEL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}