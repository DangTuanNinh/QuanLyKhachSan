using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKS
{
    class KetNoi
    {
        // Chuỗi kết nối đến cơ sở dữ liệu
        string constr = @"Data Source=DELL;Initial Catalog=QLKS1;Integrated Security=True";

        SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(constr);
        }

        public DataSet LayDuLieu(string query)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            da.Fill(ds);
            return ds;
        }

        public bool ThucThi(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                return r > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
