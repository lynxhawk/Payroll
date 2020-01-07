using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace payroll.Forms
{
    public partial class PayrollWindow : Form
    {
       
        public PayrollWindow()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new AddEmployeeWindow().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=payroll;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select*from employee";
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dr["eid"].ToString();
                lt.SubItems.Add(dr["ename"].ToString());
                lt.SubItems.Add(dr["paytype"].ToString());
                lt.SubItems.Add(dr["etype"].ToString());
                lt.SubItems.Add(dr["salary"].ToString());
                listView1.Items.Add(lt);
            }
            conn.Close();
    }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选中员工！");
                return;
            }
            ModifyInfo mi = new ModifyInfo(this.listView1.SelectedItems[0].Text);
            mi.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选中员工！");
                return;
            }
            if (MessageBox.Show("确认删除该员工?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=payroll;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "delete from employee where eid=@eid";
            cmd.Parameters.AddWithValue("@eid",int.Parse(this.listView1.SelectedItems[0].Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            }
            MessageBox.Show("删除成功");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选中员工！");
                return;
            }
            AddTimecard at = new AddTimecard(int.Parse(this.listView1.SelectedItems[0].Text),this.listView1.SelectedItems[0].SubItems[2].Text);
            at.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选中员工！");
                return;
            }
            AddRecord ad = new AddRecord(int.Parse(this.listView1.SelectedItems[0].Text), this.listView1.SelectedItems[0].SubItems[2].Text);
            ad.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选中员工！");
                return;
            }
            listView2.Items.Clear();
            listView2.Columns.Clear();
            listView2.Columns.Add("员工ID");
            listView2.Columns.Add("小时数");
            listView2.Columns.Add("日期");
            listView2.Columns.Add("是否已付");
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=payroll;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from timecard where eid=@eid";
            cmd.Parameters.AddWithValue("@eid",int.Parse(this.listView1.SelectedItems[0].Text));
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dr["eid"].ToString();
                lt.SubItems.Add(dr["hour"].ToString());
                lt.SubItems.Add(dr["date"].ToString().Substring(0,9));
                lt.SubItems.Add(dr["payed"].ToString());
                listView2.Items.Add(lt);
            }
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选中员工！");
                return;
            }
            listView2.Items.Clear();
            listView2.Columns.Clear();
            listView2.Columns.Add("员工ID");
            listView2.Columns.Add("数量");
            listView2.Columns.Add("日期");
            listView2.Columns.Add("是否已付");
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=payroll;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from record where eid=@eid";
            cmd.Parameters.AddWithValue("@eid", int.Parse(this.listView1.SelectedItems[0].Text));
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dr["eid"].ToString();
                lt.SubItems.Add(dr["count"].ToString());
                lt.SubItems.Add(dr["date"].ToString().Substring(0, 9));
                lt.SubItems.Add(dr["payed"].ToString());
                listView2.Items.Add(lt);
            }
            conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选中员工！");
                return;
            }
            listView2.Items.Clear();
            listView2.Columns.Clear();
            listView2.Columns.Add("员工ID");
            listView2.Columns.Add("工资");
            listView2.Columns.Add("支付类型");
            listView2.Columns.Add("日期");
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=payroll;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from payrecord where eid=@eid";
            cmd.Parameters.AddWithValue("@eid", int.Parse(this.listView1.SelectedItems[0].Text));
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dr["eid"].ToString();
                lt.SubItems.Add(dr["money"].ToString()); 
                lt.SubItems.Add(dr["paytype"].ToString());
                lt.SubItems.Add(dr["date"].ToString().Substring(0, 9));
                listView2.Items.Add(lt);
            }
            conn.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选中员工！");
                return;
            }
            decimal all = 0m;
            //Console.WriteLine(this.listView1.SelectedItems[0].SubItems[2].Text); //支票
            //Console.WriteLine(this.listView1.SelectedItems[0].SubItems[1].Text); //张三
            //Console.WriteLine(this.listView1.SelectedItems[0].SubItems[3].Text); //带薪雇员
            //Console.WriteLine(this.listView1.SelectedItems[0].SubItems[0].Text); //1
            //Console.WriteLine(this.listView1.SelectedItems[0].SubItems[4].Text); //100
            decimal salary = Convert.ToDecimal(this.listView1.SelectedItems[0].SubItems[4].Text);
            
            if (this.listView1.SelectedItems[0].SubItems[3].Text == "带薪雇员")
            {
                String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=payroll;";
                MySqlConnection conn = new MySqlConnection(connetStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from record where eid=@eid and payed=0";
                cmd.Parameters.AddWithValue("@eid", int.Parse(this.listView1.SelectedItems[0].Text));
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int count = int.Parse(dr["count"].ToString());
                    all = all + salary * count;
                }
                dr.Close();
                if (all == 0)
                {
                    MessageBox.Show("待支付工资为0，支付失败！");
                    return;
                }
                MySqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandText = "update record set payed=1 where eid in (@eid)";
                cmd1.Parameters.AddWithValue("@eid", int.Parse(this.listView1.SelectedItems[0].Text));
                cmd1.ExecuteNonQuery();

                MySqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandText = "insert into payrecord(eid,money,paytype,date) values(@eid,@money,@paytype,@date)";
                cmd2.Parameters.AddWithValue("@eid", int.Parse(this.listView1.SelectedItems[0].Text));
                cmd2.Parameters.AddWithValue("@money", all);
                cmd2.Parameters.AddWithValue("@paytype",this.listView1.SelectedItems[0].SubItems[2].Text);
                cmd2.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd2.ExecuteNonQuery();
                
                conn.Close();
                MessageBox.Show("支付成功");

            }
            if (listView1.SelectedItems[0].SubItems[3].Text == "正常雇员")
            {
                String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=payroll;";
                MySqlConnection conn = new MySqlConnection(connetStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from payrecord where eid=@eid";
                cmd.Parameters.AddWithValue("@eid", int.Parse(this.listView1.SelectedItems[0].Text));
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["date"].ToString().Substring(5, 2));
                    if (DateTime.Now.Month == int.Parse(dr["date"].ToString().Substring(5, 1)))
                    {
                        MessageBox.Show("当月已支付过工资，支付失败！");
                        return;
                    }                  
                }
                dr.Close();             

                MySqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandText = "insert into payrecord(eid,money,paytype,date) values(@eid,@money,@paytype,@date)";
                cmd2.Parameters.AddWithValue("@eid", int.Parse(this.listView1.SelectedItems[0].Text));
                cmd2.Parameters.AddWithValue("@money", salary);
                cmd2.Parameters.AddWithValue("@paytype", this.listView1.SelectedItems[0].SubItems[2].Text);
                cmd2.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd2.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("支付成功");
            }
            if (listView1.SelectedItems[0].SubItems[3].Text == "钟点工")
            {
                String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=payroll;";
                MySqlConnection conn = new MySqlConnection(connetStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from timecard where eid=@eid and payed=0";
                cmd.Parameters.AddWithValue("@eid", int.Parse(this.listView1.SelectedItems[0].Text));
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int hour = int.Parse(dr["hour"].ToString());
                    if (hour <= 8)
                    {
                        all = all + salary * hour;
                    }
                    else
                    {
                        all = all + salary * (hour-8) * 1.5m+salary*8;
                    }
                }
                dr.Close();
                if (all == 0)
                {
                    MessageBox.Show("待支付工资为0，支付失败！");
                    return;
                }
                MySqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandText = "update timecard set payed=1 where eid in (@eid)";
                cmd1.Parameters.AddWithValue("@eid", int.Parse(this.listView1.SelectedItems[0].Text));
                cmd1.ExecuteNonQuery();

                MySqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandText = "insert into payrecord(eid,money,paytype,date) values(@eid,@money,@paytype,@date)";
                cmd2.Parameters.AddWithValue("@eid", int.Parse(this.listView1.SelectedItems[0].Text));
                cmd2.Parameters.AddWithValue("@money", all);
                cmd2.Parameters.AddWithValue("@paytype", this.listView1.SelectedItems[0].SubItems[2].Text);
                cmd2.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd2.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("支付成功");
            }
        }
    }
}
