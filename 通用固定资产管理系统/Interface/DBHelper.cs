using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace 通用固定资产管理系统.Interface
{
    class DBHelper
    {
        public static string StrSql = "Data Source=.;Initial Catalog=manageProperty;Integrated Security=True";
        private static SqlConnection Conn = null;
        private static void InitConnection()
        {
            if (Conn == null)
                Conn = new SqlConnection(StrSql);
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
        }
        //查询，获取datareader
        public static SqlDataReader GetDataReader(string SqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(SqlStr, Conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        //查询的结果放在table表中    查询获取datatable
        public static DataTable GetDataTable(string SqlStr)
        {
            InitConnection();
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(SqlStr, Conn);
            dap.Fill(table);
            Conn.Close();
            return table;
            
        }
        //影响的行数要大于零   增删改
        public static bool ExecuteNonQuery(string SqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(SqlStr, Conn);
            int result = cmd.ExecuteNonQuery();
            Conn.Close();
            return result > 0;
        }
        //返回第一行第一列的值   执行聚合函数
        public static Object ExecuteScalar(string SqlStr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(SqlStr, Conn);
            object result = cmd.ExecuteScalar();
            Conn.Close();
            return result;
        }
    }
}
