namespace payroll.Forms
{
    partial class AddEmployeeWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.ename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.etype1 = new System.Windows.Forms.RadioButton();
            this.etype2 = new System.Windows.Forms.RadioButton();
            this.etype3 = new System.Windows.Forms.RadioButton();
            this.eid = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.accountnum = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bank = new System.Windows.Forms.RadioButton();
            this.post = new System.Windows.Forms.RadioButton();
            this.date = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.salary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // ename
            // 
            this.ename.Location = new System.Drawing.Point(149, 23);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(133, 28);
            this.ename.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "员工类型";
            // 
            // etype1
            // 
            this.etype1.AutoSize = true;
            this.etype1.Location = new System.Drawing.Point(494, 75);
            this.etype1.Name = "etype1";
            this.etype1.Size = new System.Drawing.Size(105, 22);
            this.etype1.TabIndex = 5;
            this.etype1.TabStop = true;
            this.etype1.Text = "正常雇员";
            this.etype1.UseVisualStyleBackColor = true;
            // 
            // etype2
            // 
            this.etype2.AutoSize = true;
            this.etype2.Location = new System.Drawing.Point(494, 123);
            this.etype2.Name = "etype2";
            this.etype2.Size = new System.Drawing.Size(105, 22);
            this.etype2.TabIndex = 6;
            this.etype2.TabStop = true;
            this.etype2.Text = "带薪雇员";
            this.etype2.UseVisualStyleBackColor = true;
            // 
            // etype3
            // 
            this.etype3.AutoSize = true;
            this.etype3.Location = new System.Drawing.Point(494, 168);
            this.etype3.Name = "etype3";
            this.etype3.Size = new System.Drawing.Size(87, 22);
            this.etype3.TabIndex = 7;
            this.etype3.TabStop = true;
            this.etype3.Text = "钟点工";
            this.etype3.UseVisualStyleBackColor = true;
            // 
            // eid
            // 
            this.eid.Location = new System.Drawing.Point(149, 75);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(133, 28);
            this.eid.TabIndex = 8;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(149, 123);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(133, 28);
            this.address.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "银行账号";
            // 
            // accountnum
            // 
            this.accountnum.Location = new System.Drawing.Point(149, 183);
            this.accountnum.Name = "accountnum";
            this.accountnum.Size = new System.Drawing.Size(208, 28);
            this.accountnum.TabIndex = 12;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(24, 36);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(69, 22);
            this.check.TabIndex = 13;
            this.check.TabStop = true;
            this.check.Text = "支票";
            this.check.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bank);
            this.groupBox1.Controls.Add(this.post);
            this.groupBox1.Controls.Add(this.check);
            this.groupBox1.Location = new System.Drawing.Point(44, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 181);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "支付类型";
            // 
            // bank
            // 
            this.bank.AutoSize = true;
            this.bank.Location = new System.Drawing.Point(24, 114);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(105, 22);
            this.bank.TabIndex = 15;
            this.bank.TabStop = true;
            this.bank.Text = "银行汇款";
            this.bank.UseVisualStyleBackColor = true;
            // 
            // post
            // 
            this.post.AutoSize = true;
            this.post.Location = new System.Drawing.Point(24, 76);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(69, 22);
            this.post.TabIndex = 14;
            this.post.TabStop = true;
            this.post.Text = "邮寄";
            this.post.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(572, 299);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 28);
            this.date.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(668, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(572, 223);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(200, 28);
            this.salary.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "薪水";            
            // 
            // AddEmployeeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 427);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.accountnum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.address);
            this.Controls.Add(this.eid);
            this.Controls.Add(this.etype3);
            this.Controls.Add(this.etype2);
            this.Controls.Add(this.etype1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ename);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployeeWindow";
            this.Text = "增加员工";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton etype1;
        private System.Windows.Forms.RadioButton etype2;
        private System.Windows.Forms.RadioButton etype3;
        private System.Windows.Forms.TextBox eid;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox accountnum;
        private System.Windows.Forms.RadioButton check;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bank;
        private System.Windows.Forms.RadioButton post;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label8;
    }
}