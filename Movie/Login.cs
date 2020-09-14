using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void DENLU(string ID, string PWD) 
        {
        
        }
        private void button1_Click(object sender, EventArgs e)//登录
        {
            string ID = comboBox1.Text;
            string PWD = textBox1.Text;
            if (ID != "" && PWD != "")
            {
                if (ID.Length==11)
                {
                    bool asd = IsHandset(ID);
                    if (asd)
                    {
                        string asdd = "select count(*) from Client where ClientId='" + ID + "'";
                        DBTools bb = new DBTools();
                        int clienID = bb.Login(asdd);

                        if (clienID == 1)
                        {
                            string sql = "select count(*) from Client where ClientId='" + ID + "' and ClientPwd='" + PWD + "'";
                            DBTools cc = new DBTools();
                            int login = cc.Login(sql);
                            if (login == 1)
                            {
                                //验证成功后将用户名传给Program定义的变量username
                                Program.username = comboBox1.Text.Trim();
                                //定义验证成功时返回值                    
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            { MessageBox.Show("账户或密码错误！"); }
                        }
                        else
                        {
                            MessageBox.Show("此用户不存在，请先注册");
                        }
                    }
                    else
                    {
                        MessageBox.Show("手机号格式不正确");
                    }
                }
                else
                {
                    MessageBox.Show("手机号长度不够");
                }  
                }
                else
                    { MessageBox.Show("请输入账户和密码！"); }
        }
        public bool IsHandset(string str_handset)//检验手机号码的和法性
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str_handset, @"^[1]+[3,9]+\d{9}");
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Register cc = new Register();
            cc.Show();
        }
        
    }
}
