using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class AccessData
    {
        public SqlConnection GetConnection()
        {
            //return new SqlConnection(@"Data Source=MSI;Initial Catalog=DB_chat;Integrated Security=True");
            return new SqlConnection(@"Data Source=HANKPHAM\SQLEXPRESS;Initial Catalog=DB_Chat;Integrated Security=True");

        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
        }
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
