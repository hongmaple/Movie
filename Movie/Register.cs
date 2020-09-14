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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//注册
        {
            bool kdfg = ksdjhfg();
            if (kdfg==false)
            {
                string ID = comboBox1.Text;
                string PWD = textBox1.Text;
                string quePWD = textBox2.Text;

                if (ID != "" && PWD != "" && quePWD != ""&&textBox3.Text!="")
                {
                    if (ID.Length == 11)
                    {
                        bool asd = IsHandset(ID);
                        if (asd)
                        {
                            if (PWD.Length >= 6 && PWD.Length <= 12)
                            {
                                if (PWD == quePWD)
                                {
                                    if (textBox3.Text==he.ToString())
                                    {
                                        string asdd = @"INSERT INTO [movieDB].[dbo].[Client]
                                   ([ClientId]
                                   ,[ClientPwd])
                             VALUES
                                   ('" + ID + "','" + PWD + "')";
                                        DBTools bb = new DBTools();
                                        int clienID = bb.DonIntsdf(asdd);
                                        if (clienID == 1)
                                        {
                                            MessageBox.Show("注册成功,立即返回登录界面", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("注册失败");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("验证码不正确");
                                    }
                                    
                                    }else
                                    {
                                        MessageBox.Show("密码不一致");
                                    }
                            }
                            else
                            {
                                MessageBox.Show("密码长度限制在6-12位");
                            }
                        }
                        else
                        {
                            MessageBox.Show("手机号格式不正确");
                        }
                    }
                    else
                    {
                        MessageBox.Show("手机号长度不正确");
                    }
                }
                else
                { MessageBox.Show("请完善信息！"); }
            }
            else
            {
                MessageBox.Show("此用户已注册");
            }
        }
        public bool IsHandset(string str_handset)//检验手机号码的合法性
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str_handset, @"^[1]+[3,9]+\d{9}");
        }
        public bool ksdjhfg()//检验是否已注册 
        {
            string asdd = "select count(*) from Client where ClientId='" + comboBox1.Text+"'";
            DBTools bb = new DBTools();
            int clienID = bb.Login(asdd);
            if (clienID==1)
            {
                 return true;
            }
            else
            {
               return false;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)//检验是否已注册
        {
            bool sdfsdf = ksdjhfg();
            if (sdfsdf)
            {
                MessageBox.Show("此用户已注册");
            }
        }
        private void button2_Click(object sender, EventArgs e)//返回登录
        {
            this.Close();
        }
        int he = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number1 = random.Next(0, 10);//生成一个一位数
            int number2 = random.Next(0,10);//生成一个一位数
            he = number1 + number1;//合
            textBox4.Text = number1 +"+"+ number1+"=";
        }
    }
}
