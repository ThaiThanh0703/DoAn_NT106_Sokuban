using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public static class SqlConnectionData
    {
        // Tạo kết nối cơ sở dữ liệu
        public static SqlConnection Connect()
        {
            string sqlcon = @"Data Source=CHI-CHAN\VOTHANH;Initial Catalog=CSDLPlayer_DoAn;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlcon);
            return conn;
        }
    }
    public class DatabaseAccess
    {
        protected static string CheckAccount(PlayerAccount account)
        {
            string user = null;
            SqlConnection con = SqlConnectionData.Connect();
            con.Open();
            SqlCommand command = new SqlCommand("proc_checkacc", con);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@username", account.sUsername);
            command.Parameters.AddWithValue("@password", account.sPassword);
            command.Connection = con;
            SqlDataReader reader=command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                con.Close();
            }
            else
            {
                return "incorrect_data";
            }

            return user;
        }
    }
}
