using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class DATA
    {

        public static SqlConnection Openconnect()
        {
            string sChuoiKetNoi = @"Data Source=LAPTOP-2MEF69I3\SQLEXPRESS;Initial Catalog=WatchStore;Integrated Security=True;Trust Server Certificate=True";

            SqlConnection con = new SqlConnection(sChuoiKetNoi);
            con.Open();
            return con;
        }
        public static void Disconnect(SqlConnection con)
        {
            con.Close();
        }
        public static int JustExcuteNoParameter(string sql)
        {
            SqlConnection con = Openconnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            int rows = cmd.ExecuteNonQuery();
            Disconnect(con);
            if (rows > 0)
            {
                return rows;
            }
            else
            {
                return -1;
            }
        }

        public static int JustExcuteWithParameter(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(sql))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetTable(string sql)
        {
            SqlConnection con = Openconnect();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Disconnect(con);
            return dt;
        }
        public static DataTable GetTableWithParameters(string sql, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection con = Openconnect())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddRange(parameters);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing query: " + ex.Message);
            }
        }
        public static int ExecuteCommand(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = Openconnect())
            {
                //conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        }
}
