using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNhom
{
    class DBAccess
    {
        public static string strConn = "Data Source=DESKTOP-99CQB5H;Initial Catalog=TTN_QL_KhachSan;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection();
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        public void createConn()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void readDataToAdapter(string query, DataTable table)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    createConn();
                }
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                adt = new SqlDataAdapter(cmd);
                adt.Fill(table);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}