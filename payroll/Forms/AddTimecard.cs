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
    public partial class AddTimecard : Form
    {
        public AddTimecard(int eid,string paytype)
        {
            InitializeComponent();
            this.eid.Text = eid.ToString();
            this.paytype.Text = paytype;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connetStr = "server=127.0.0.1;port=3306;user=root;password=123456; database=payroll;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            conn.Open();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO timecard(eid,hour,paytype,date)" +
                    "VALUES(@eid,@hour,@paytype,@date)";
                cmd.Parameters.AddWithValue("@hour", int.Parse(hour.Text));
                cmd.Parameters.AddWithValue("@paytype", paytype.Text);
                cmd.Parameters.AddWithValue("@date", date.Text);
                cmd.Parameters.AddWithValue("@eid", eid.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            conn.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
