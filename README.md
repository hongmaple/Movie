# Movie
电影售票系统
# 1绪论

## 1.1任务目的

用《数据结构》中的链表做数据结构，结合c#语言基本知识，编写一个电影票预定系统，以把所学知识应用到实际软件开发中去。了解并掌握数据结构与算法的设计方法，具备初步的独立分析和设计能力，初步掌握软件开发过程的问题分析，系统设计，程序编码，测试等基本方法和技能：提高综合运用所学的理论知识和方法独立分析和解决问题的能力，训练用系统的观点和软件开发一般规范进行软件开发，培养软件工作者所应具备的科学的工作方法和作风。

## 1.2需求分析

设计一个实用的电影票预定系统，采用sqlserver数据库，采用集合等相关数据结构，编写一个能够注册用户，实现登录，查询电影信息，预定电影票，退订电影票，删除订单记录，修改账号信息等功能

## 1.3详细功能 

1.注册用户         

2.登录        

3.验证码          

4.查询电影票信息       

5.预定电影票生成订单                  

6.退订        

7.删除订单 

8.修改用户信息         

# 2概要设计

 #### 2.1.1表关系
![image-20200916145340490](\imgs\屏幕截图 2020-09-16 145348.jpg)

 #### 2.1.2流程逻辑

![image-20200916150815847](\imgs\屏幕截图 2020-09-16 150409.jpg)

# 3部分代码设计

## 3.1业务逻辑实现

#### 3.1.1登录

```C#
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
```

![image-20200916142323827](\imgs\屏幕截图 2020-09-16 142332.jpg)

#### 3.1.2 注册

```C#
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
```

![image-20200916142725689](\imgs\屏幕截图 2020-09-16 142713.jpg)

#### 3.1.3广告

![image-20200916142953471](\imgs\屏幕截图 2020-09-16 143000.jpg)

#### 3.1.3影片列表预定

```C#
 public Form1()
        {
            InitializeComponent();
        }
        DBTools cc = new DBTools();
        DataSet movie = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            string sql="";
            int movieID = int.Parse(comboBox1.SelectedValue.ToString());
            if (movieID > 0)
            {
                sql = " HouseID=" + movieID;
            }
            dv.RowFilter = sql;
        }
        DataView dv;
        private void Form1_Load(object sender, EventArgs e)//加载部门名称
        {
            try
            {
                string sql = @"SELECT [HouseID]
                          ,[MovieHouse]
                      FROM [movieDB].[dbo].[MovieHouse]
                    GO";
               movie=cc.QuerByAdapter(sql, "movie");
          
                DataRow row = movie.Tables["movie"].NewRow();
                row[0] = -1;
                row[1] = "请选择";
                movie.Tables["movie"].Rows.InsertAt(row, 0);//添加到表的第一行位置
            
                comboBox1.DisplayMember = "MovieHouse";//显示的值
                comboBox1.ValueMember = "HouseID";//实际值
                comboBox1.DataSource = movie.Tables["movie"];

                string sql2 = @"SELECT [TicketId]
                          ,[MovieName]
                          ,Movie.[HouseID]
                          ,[StartTime]
                          ,[EndTime]
                          ,[TicketPrice]
                          ,[number]
                          ,[MovieHouse]
                      FROM [movieDB].[dbo].[Movie]
                      inner join [movieDB].[dbo].[MovieHouse]
                      on Movie.HouseID=MovieHouse.HouseID";
                movie = cc.QuerByAdapter(sql2, "MovieList");
                dv=new DataView( movie.Tables["MovieList"]);
                dataGridView1.DataSource = dv;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string moiveid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string sql = @"SELECT [TicketId]
                          ,[MovieHouse]
                          ,[EndTime]
                          ,[TicketPrice]
                          ,[MovieName]
                          ,[StartTime]
                          ,[number]
                      FROM [movieDB].[dbo].[Movie],[movieDB].[dbo].[MovieHouse]
                      where TicketId='" + moiveid + "' and Movie.HouseID=MovieHouse.HouseID";
            movie = cc.QuerByAdapter(sql,"sadfg");
            textBox1.Text = movie.Tables["sadfg"].Rows[0][0].ToString(); //编号
            textBox2.Text = movie.Tables["sadfg"].Rows[0][1].ToString(); //影院
            textBox3.Text = movie.Tables["sadfg"].Rows[0][2].ToString(); //散场时间
            textBox4.Text = movie.Tables["sadfg"].Rows[0][3].ToString();//会员票价
            textBox5.Text = movie.Tables["sadfg"].Rows[0][4].ToString();//电影名称
            textBox6.Text = movie.Tables["sadfg"].Rows[0][5].ToString();//开场时间
            textBox7.Text = movie.Tables["sadfg"].Rows[0][6].ToString();//剩余票数
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sdf = 0;
            Random random = new Random();
            int number=Convert.ToInt32(numericUpDown1.Value);//电影票的张数
            string moiveid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//影院ID
            string dindanbianh = "";
            if (number<=int.Parse(textBox7.Text.ToString()))
            {
                for (int i = 1; i <= number; i++)
                {
                    int orderId = random.Next(100000, 999999);//生成一个六位随机数作为订单编号
                    string sql = string.Format(@"INSERT INTO [movieDB].[dbo].[OrderInfo]
                           ([OrderId]
                           ,[TicketId]
                           ,[number]
                           ,[State])
                     VALUES ({0},'{1}','{2}','{3}')
                     ;UPDATE [movieDB].[dbo].[Movie] SET [number]=[number]-{4} WHERE TicketId='{5}'"
                          , orderId, moiveid, number, "已预订", number, moiveid);
                    Convert.ToInt32(cc.DonIntsdf(sql));

                    string sql2 = string.Format(@"INSERT INTO client_order([OrderId],[ClientId])  VALUES ('{0}','{1}')", orderId, Program.username);
                    sdf = Convert.ToInt32(cc.DonIntsdf(sql2));
                    dindanbianh = dindanbianh + orderId;
                }
                if (sdf > 0)
                {
                    MessageBox.Show("预订成功，订单编号为:" + dindanbianh, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("预订的票数不能超过剩余票数");
            }
        }
```

![image-20200916143147663](\imgs\屏幕截图 2020-09-16 143135.jpg)

#### 3.1.4订单退订与删除

```C#
private string open = "server=.;uid=sa;pwd=sasa;database=movieDB";//连接数据库的语句
        public State()
        {
            InitializeComponent();
        }
        DataSet Moielist = new DataSet();
        private void State_Load(object sender, EventArgs e)
        {
            loadDate();
        }

        private void loadDate()
        {
            DataTable objdt = (DataTable)dataGridView1.DataSource;
            if (objdt != null)
            {
                objdt.Rows.Clear();
            }
            
            dataGridView1.DataSource = objdt;
            SqlConnection conn = new SqlConnection(open);
            string sql = @"SELECT m.[TicketId]
                          ,m.[MovieName]
                          ,h.[MovieHouse]
                          ,m.[StartTime]
                          ,m.[EndTime]
                          ,m.[TicketPrice]
                          ,o.[number]
                          ,o.[OrderId]
                          ,o.[State]
                          ,c.[id]
                      FROM [movieDB].[dbo].[OrderInfo] o
                      left join [movieDB].[dbo].[Movie] m on m.TicketId=o.TicketId
                      left join [movieDB].[dbo].[MovieHouse] h on h.HouseID=m.HouseID
                      left join client_order c on o.OrderId = c.OrderId
                      where c.ClientId='" + Program.username + "'";
            SqlDataAdapter MovieList = new SqlDataAdapter(sql, conn);
            MovieList.Fill(Moielist, "MovieList");
            dataGridView1.DataSource = Moielist.Tables["MovieList"];
        }

        private void tuidinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择一列数据");
                return;
            }
            int a = dataGridView1.SelectedRows[0].Index;
            int OrderId = (int)dataGridView1.Rows[a].Cells["OrderId"].Value;
            string sql = string.Format(@"update OrderInfo set State='{0}' where OrderId='{1}'", "已退订", OrderId);
            DBTools bb = new DBTools();
            int i = bb.DonIntsdf(sql);
            if (i > 0)
            {
                MessageBox.Show("退订成功");
                loadDate();
            }
            else
            {
                MessageBox.Show("退订失败");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择一列数据");
                return;
            }
            int a = dataGridView1.SelectedRows[0].Index;
            int OrderId = (int)dataGridView1.Rows[a].Cells["OrderId"].Value;
            string state = dataGridView1.Rows[a].Cells["Column8"].Value.ToString().Trim();
            if (state=="已退订")
            {
                string sql = string.Format(@"DELETE FROM OrderInfo  where OrderId='{0}'", OrderId);
                DBTools bb = new DBTools();
                string sql2 = string.Format(@"DELETE FROM client_order where OrderId='{0}'", OrderId);
                int i = bb.DonIntsdf(sql);
                if (i > 0)
                {
                    MessageBox.Show("删除成功");
                    loadDate();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            else
            {
                MessageBox.Show("只可删除已退订的订单");
            }
        }
```

在UI设计上是采用右键菜单的方式来调用方法的

![image-20200916143732372](\imgs\屏幕截图 2020-09-16 143719.jpg)

3.1.5账号信息查看与保存

```C#
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
```

![image-20200916144107680](\imgs\屏幕截图 2020-09-16 144113.jpg)

# 4调试结果

经过反复测试，最终提供了一个操作简便的系统，而且容错能力较好，稳定性不错，在调试过程中，有一些小错误，但都只是基本的书写错误，而在文件保存方面，实现了实时保存和读取，在删除功能方面我做了较多努力，整体界面设计较为合理，对于输入的姓名，查找出结果后是否删除，若有重名，则会二次显示，提示是否删除，一直到所有记录查询结束，结束之后可以直接在此删除其他记录，因为它提供循环删除的功能。

# 5总结

通过做这个课程设计我了解并掌握了数据结构与算法的设计方法，初步掌握了独立分析和设计能力，遗迹软件开发过程的问题分析，系统设计，程序编码，测试等基本方法和技能，使我提高了编写技术文献的能力

# 6参考文献

[1] 严蔚敏，吴伟民. 数据结构（C#语言版）[M]. 北京：清华大学出版社, 2007.

[2] 何钦铭，冯雁，陈越. 数据结构课程设计.浙江：浙江大学出版社, 2007.

[3] 李春葆，陶红艳，金晶，赵丙秀. 数据结构与算法教程. 北京：清华大学出版社, 2007.
