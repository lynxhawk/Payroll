namespace payroll.Forms
{
    partial class AddRecord
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
            this.eid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paytype = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工ID";
            // 
            // eid
            // 
            this.eid.AutoSize = true;
            this.eid.Location = new System.Drawing.Point(269, 63);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(62, 18);
            this.eid.TabIndex = 1;
            this.eid.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "支付方式";
            // 
            // paytype
            // 
            this.paytype.AutoSize = true;
            this.paytype.Location = new System.Drawing.Point(272, 114);
            this.paytype.Name = "paytype";
            this.paytype.Size = new System.Drawing.Size(62, 18);
            this.paytype.TabIndex = 3;
            this.paytype.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "日期";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(269, 210);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(157, 28);
            this.date.TabIndex = 5;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(272, 160);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(154, 28);
            this.count.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "数量";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 339);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.count);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paytype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eid);
            this.Controls.Add(this.label1);
            this.Name = "AddRecord";
            this.Text = "AddRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label eid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label paytype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}