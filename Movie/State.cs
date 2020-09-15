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
    }
}
