using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Quizzer
{
    public class Connection
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand comm;


        public int ConnectDBase(string location)
        {
            if (location == null) 
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Quizzer;Integrated Security=True";
                conn.Open();
                conn.Close();
                return 1;
            }
            catch
            {
                return 0; 
            }

            else
            {

                try
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=.\\SQLEXPRESS; AttachDbFilename=" + location + ";Integrated Security=True";
                    conn.Open();
                    conn.Close();
                    return 1;
                }

                catch{
                    return 0;
                }
            }
        
            

        }



        public int CustomNonQuery(string query)
        {
            conn.Open();
            comm = new SqlCommand(""+query+"", conn);
            int n = comm.ExecuteNonQuery();
            conn.Close();
            return n;
        }


        public int CustomInsertion(string table, string column, string values)
        {
            conn.Open();
            comm = new SqlCommand("Insert Into " + table + " (" + column + ") values (" + values + ");", conn);
            int n = comm.ExecuteNonQuery();
            conn.Close();
            return n;
        }

        public DataTable CustomSelect(string column, string table, string where)
        {
            conn.Open();
            da = new SqlDataAdapter("Select " + column + " from " + table + " " + where + ";", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }

    }
}
