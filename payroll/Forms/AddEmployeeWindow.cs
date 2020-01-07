using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll.Forms
{
    public partial class AddEmployeeWindow : Form
    {
        public AddEmployeeWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string etype=null;
            string paytype = null;
            if (check.Checked == true)
            {
                paytype = check.Text;
            }
            if (post.Checked == true)
            {
                paytype = post.Text;
            }
            if (bank.Checked == true)
            {
                paytype = bank.Text;
            }
            if (etype1.Checked == true)
            {
                etype = etype1.Text;
            }
            if (etype2.Checked == true)
            {
                etype = etype2.Text;
            }
            if(etype3.Checked==true)
            {
                etype = etype3.Text;
            }
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=payroll;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            conn.Open();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO employee(eid,etype,paytype,salary,ename,accountnum,address,startdate)" +
                    "VALUES(@eid,@etype,@paytype,@salary,@ename,@accountnum,@address,@startdate)";
                cmd.Parameters.AddWithValue("@eid",int.Parse(eid.Text));
                cmd.Parameters.AddWithValue("@etype",etype);
                cmd.Parameters.AddWithValue("@paytype",paytype);
                cmd.Parameters.AddWithValue("@salary",Convert.ToDecimal(salary.Text));
                cmd.Parameters.AddWithValue("@ename", ename.Text);
                cmd.Parameters.AddWithValue("@accountnum",accountnum.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@startdate",date.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            conn.Close();
            this.Close();
        }
    }
}
