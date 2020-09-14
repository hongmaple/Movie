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
    public partial class State : Form
    {
        private string open = "server=.;uid=sa;pwd=sasa;database=movieDB";//连接数据库的语句
        public State()
        {
            InitializeComponent();
        }
        DataSet Moielist = new DataSet();
        private void State_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(open);
            string sql = @"SELECT Movie.[TicketId]
                          ,Movie.[MovieName]
                          ,Movie.[HouseID]
                          ,Movie.[StartTime]
                          ,Movie.[EndTime]
                          ,Movie.[TicketPrice]
                          ,OrderInfo.[number]
                          ,OrderInfo.[OrderId]
                          ,OrderInfo.[State]
                      FROM [movieDB].[dbo].[Movie],[movieDB].[dbo].[OrderInfo]
                      where Movie.TicketId=OrderInfo.TicketId";
            SqlDataAdapter MovieList = new SqlDataAdapter(sql, conn);
            MovieList.Fill(Moielist, "MovieList");
            dataGridView1.DataSource = Moielist.Tables["MovieList"];
        }
    }
}
