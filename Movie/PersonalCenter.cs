using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Movie
{
    public partial class PersonalCenter : Form
    {
        public PersonalCenter()
        {
            InitializeComponent();
        }

        private void PersonalCenter_Load(object sender, EventArgs e)
        {
            string sql = "select * from Client where ClientId='" + Program.username + "'";
            DBTools bb = new DBTools();
            SqlDataReader reder = bb.reader(sql);
            while (reder.Read())
            {
                label2.Text = reder["ClientId"].ToString();
                textBox1.Text = reder["name"].ToString();
                textBox2.Text = reder["age"].ToString();
                textBox3.Text = reder["ClientPwd"].ToString();
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"update Client set ClientPwd='{0}',name='{1}',age={2} where ClientId='{3}'",textBox3.Text, textBox1.Text, textBox2.Text,Program.username);
            DBTools bb = new DBTools();
            int i = bb.DonIntsdf(sql);
            if (i > 0)
            {
                MessageBox.Show("保存成功");
            }
            else
            {
                MessageBox.Show("保存失败");
            }
        }
    }
}
