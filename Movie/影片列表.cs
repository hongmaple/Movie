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
    public partial class 影片列表 : Form
    {
        public 影片列表()
        {
            InitializeComponent();
        }
        DataSet Moielist = new DataSet();
        private void 影片列表_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT [TicketId]
                          ,[MovieName]
                          ,[HouseID]
                          ,[StartTime]
                          ,[EndTime]
                          ,[TicketPrice]
                          ,[number]
                      FROM [movieDB].[dbo].[Movie]";
            DBTools dfg = new DBTools();
            Moielist = dfg.QuerByAdapter(sql, "MovieList");
            dataGridView1.DataSource = Moielist.Tables["MovieList"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            支付 sdfsdf = new 支付();
            sdfsdf.Show();
        }
    }
}
