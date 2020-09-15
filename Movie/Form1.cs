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
    public partial class Form1 : Form
    {
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
    }
}
