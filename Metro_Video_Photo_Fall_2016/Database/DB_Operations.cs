using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Metro_Video_Photo_Fall_2016.Database
{
    public class DB_Operations
    {
        private String GetConnectionString()
        {
            try
            {
                if (GetDbType() == 1)
                    return ConfigurationManager.AppSettings["SqlServerConnectionString"];
                else
                    return ConfigurationManager.AppSettings["AccessConnectionString"];
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        private int GetDbType()
        {
            int type = -1;
            try
            {
                type = Convert.ToInt32(ConfigurationManager.AppSettings["DatabaseType"]);
            }
            catch (Exception ex)
            {

            }
            return type;
        }

        public int InsertUpdateDeleteQry(string sql)
        {
            // bool isSuccess = false;
            int rowsAffected = 0;
            try
            {
                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;
                        cmd.Connection = conn;
                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {

            }
            catch (Exception ex)
            {
                
            }
            return rowsAffected;
        }

        public DataTable SelectQry(string sql)
        {
            OleDbConnection connection = new OleDbConnection(GetConnectionString());
            OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                oledbAdapter.SelectCommand = new OleDbCommand(sql, connection);
                oledbAdapter.Fill(dt);
            }
            catch (SqlException e)
            {

            }
            catch (Exception ex)
            {

            }
            finally 
            {
                oledbAdapter.Dispose();
                connection.Close();
            }
            return dt;
        }

        public int ScalarQry(string sql)
        {
            int count = -1;
            using (OleDbConnection connection = new OleDbConnection(GetConnectionString())) 
            {
                using (OleDbCommand cmd = new OleDbCommand(sql, connection)) 
                {
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        connection.Open();
                        count = (Int32)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return count;
        }
    }
}