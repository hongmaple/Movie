using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Movie
{
    class DBTools
    {
        private string open = "server=.;uid=sa;pwd=sasa;database=movieDB";//连接数据库的语句
        public DataSet QuerByAdapter(string sql,string tableName)//用于执行查询的方法
        {
            DataSet movie = new DataSet();//创建临时数据库供全局使用
            SqlConnection conn = new SqlConnection(open);
            SqlDataAdapter adaer = new SqlDataAdapter(sql,conn);
            adaer.Fill(movie, tableName);
            return movie;
        }

        public SqlDataReader reader(string sql)
        {
            SqlConnection con = new SqlConnection(open);
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader reader = com.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        public int DonIntsdf(string sql) //用于执行增删改的方法
        {
            int rs = 0;
            SqlConnection conn = new SqlConnection(open);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            rs = cmd.ExecuteNonQuery();
            conn.Close();
            return rs;
        }
        public int Login(string sql)//用于执行查询的方法
        {
            int login = 0;
            SqlConnection conn = new SqlConnection(open);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            login = Convert .ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return login;
        }
    }
}
