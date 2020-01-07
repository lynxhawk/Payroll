namespace payroll.Forms
{
    partial class ModifyInfo
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ename = new System.Windows.Forms.TextBox();
            this.etype1 = new System.Windows.Forms.RadioButton();
            this.etype2 = new System.Windows.Forms.RadioButton();
            this.etype3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.accountnum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bank = new System.Windows.Forms.RadioButton();
            this.post = new System.Windows.Forms.RadioButton();
            this.check = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "员工ID";
            // 
            // eid
            // 
            this.eid.AutoSize = true;
            this.eid.Location = new System.Drawing.Point(113, 29);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(62, 18);
            this.eid.TabIndex = 3;
            this.eid.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "员工姓名";
            // 
            // ename
            // 
            this.ename.Location = new System.Drawing.Point(122, 71);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(184, 28);
            this.ename.TabIndex = 5;
            // 
            // etype1
            // 
            this.etype1.AutoSize = true;
            this.etype1.Location = new System.Drawing.Point(422, 45);
            this.etype1.Name = "etype1";
            this.etype1.Size = new System.Drawing.Size(105, 22);
            this.etype1.TabIndex = 6;
            this.etype1.TabStop = true;
            this.etype1.Text = "正常雇员";
            this.etype1.UseVisualStyleBackColor = true;
            // 
            // etype2
            // 
            this.etype2.AutoSize = true;
            this.etype2.Location = new System.Drawing.Point(422, 97);
            this.etype2.Name = "etype2";
            this.etype2.Size = new System.Drawing.Size(105, 22);
            this.etype2.TabIndex = 7;
            this.etype2.TabStop = true;
            this.etype2.Text = "带薪雇员";
            this.etype2.UseVisualStyleBackColor = true;
            // 
            // etype3
            // 
            this.etype3.AutoSize = true;
            this.etype3.Location = new System.Drawing.Point(422, 147);
            this.etype3.Name = "etype3";
            this.etype3.Size = new System.Drawing.Size(87, 22);
            this.etype3.TabIndex = 8;
            this.etype3.TabStop = true;
            this.etype3.Text = "钟点工";
            this.etype3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "薪水";
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(501, 210);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(178, 28);
            this.salary.TabIndex = 12;            
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(122, 126);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(184, 28);
            this.address.TabIndex = 15;
            // 
            // accountnum
            // 
            this.accountnum.Location = new System.Drawing.Point(122, 178);
            this.accountnum.Name = "accountnum";
            this.accountnum.Size = new System.Drawing.Size(184, 28);
            this.accountnum.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "地址";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "银行账号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bank);
            this.groupBox1.Controls.Add(this.post);
            this.groupBox1.Controls.Add(this.check);
            this.groupBox1.Location = new System.Drawing.Point(29, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 143);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "支付方式";
            // 
            // bank
            // 
            this.bank.AutoSize = true;
            this.bank.Location = new System.Drawing.Point(28, 95);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(105, 22);
            this.bank.TabIndex = 2;
            this.bank.TabStop = true;
            this.bank.Text = "银行汇款";
            this.bank.UseVisualStyleBackColor = true;
            // 
            // post
            // 
            this.post.AutoSize = true;
            this.post.Location = new System.Drawing.Point(28, 66);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(69, 22);
            this.post.TabIndex = 1;
            this.post.TabStop = true;
            this.post.Text = "邮寄";
            this.post.UseVisualStyleBackColor = true;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(28, 37);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(69, 22);
            this.check.TabIndex = 0;
            this.check.TabStop = true;
            this.check.Text = "支票";
            this.check.UseVisualStyleBackColor = true;
            // 
            // ModifyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.accountnum);
            this.Controls.Add(this.address);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.etype3);
            this.Controls.Add(this.etype2);
            this.Controls.Add(this.etype1);
            this.Controls.Add(this.ename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ModifyInfo";
            this.Text = "ModifyInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label eid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ename;
        private System.Windows.Forms.RadioButton etype1;
        private System.Windows.Forms.RadioButton etype2;
        private System.Windows.Forms.RadioButton etype3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox accountnum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bank;
        private System.Windows.Forms.RadioButton post;
        private System.Windows.Forms.RadioButton check;
    }
}