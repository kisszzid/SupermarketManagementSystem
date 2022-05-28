﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SupermarketManagementSystem
{
    internal class Class2
    {
        public static string ConnString = "server=.;database=sqw;uid =sa;pwd =123456";
        public static SqlConnection Conn = null;
        public static void InitConnection()
        {
            if (Conn == null)
            {
                Conn = new SqlConnection(ConnString);
            }
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
            if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
        }


        public static SqlDataReader GetDataReader(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr, Conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public static bool ExecuteNonQuery(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr, Conn);
            int result = cmd.ExecuteNonQuery();
            Conn.Close();
            return result > 0;
        }
        public static object ExecuteScalar(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr, Conn);
            object result = cmd.ExecuteScalar();
            Conn.Close();
            return result;
        }
    }
}
