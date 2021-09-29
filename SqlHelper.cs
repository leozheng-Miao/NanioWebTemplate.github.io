using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Test1
{
    public class SqlHelper
    {
        public static string strConn = ConfigurationManager.AppSettings["connStr"];

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="cmdText">sql字符串</param>
        /// <param name="cmdType">sql类型</param>
        /// <param name="cmdParms">参数集</param>
        public static void ExecuteNonQuery(string cmdText, CommandType cmdType, params SqlParameter[] cmdParms)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            ExecuteNonQuery(conn, cmdText, cmdType, cmdParms);
        }

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="conn">SqlConnection</param>
        /// <param name="cmdText">sql字符串</param>
        /// <param name="cmdType">sql类型</param>
        /// <param name="cmdParms">参数集</param>
        //public static void ExecuteNonQuery(IDbConnection conn, string cmdText, CommandType cmdType, params SqlParameter[] cmdParms)
        public static void ExecuteNonQuery(SqlConnection conn, string cmdText, CommandType cmdType, params SqlParameter[] cmdParms)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand();
            try
            {
                //conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                if (cmdParms != null)
                {
                    foreach (SqlParameter parm in cmdParms)
                    {
                        cmd.Parameters.Add(parm);
                    }
                }
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }


        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="conn">SqlConnection</param>
        /// <param name="cmdText">sql字符串</param>
        /// <param name="cmdType">sql类型</param>
        /// <param name="cmdParms">参数集</param>
        //public static void ExecuteNonQuery(IDbConnection conn, string cmdText, CommandType cmdType, params SqlParameter[] cmdParms)
        public static void ExecuteNonQuery(SqlTransaction tran, SqlConnection conn, string cmdText, CommandType cmdType, params SqlParameter[] cmdParms)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand();
            try
            {
                //conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                cmd.Transaction = tran;
                if (cmdParms != null)
                {
                    foreach (SqlParameter parm in cmdParms)
                    {
                        cmd.Parameters.Add(parm);
                    }
                }
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
            }
        }


        /// <summary>
        /// 执行SQL语句并返回第一行第一列的数据
        /// </summary>
        /// <param name="cmdText">sql字符串</param>
        /// <param name="cmdType">sql类型</param>
        /// <param name="cmdParms">参数集</param>
        /// <returns></returns>
        public static object ExecuteScalar(string cmdText, CommandType cmdType, params SqlParameter[] cmdParms)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            return ExecuteScalar(conn, cmdText, cmdType, cmdParms);
        }

        /// <summary>
        /// 执行SQL语句并返回第一行第一列的数据
        /// </summary>
        /// <param name="conn">SqlConnection</param>
        /// <param name="cmdText">sql字符串</param>
        /// <param name="cmdType">sql类型</param>
        /// <param name="cmdParms">参数集</param>
        /// <returns></returns>
        public static object ExecuteScalar(SqlConnection conn, string cmdText, CommandType cmdType, params SqlParameter[] cmdParms)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                //conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                if (cmdParms != null)
                {
                    foreach (SqlParameter parm in cmdParms)
                    {
                        cmd.Parameters.Add(parm);
                    }
                }
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        /// <summary>
        /// 执行SQL语句并返回第一行第一列的数据
        /// </summary>
        /// <param name="conn">SqlConnection</param>
        /// <param name="cmdText">sql字符串</param>
        /// <param name="cmdType">sql类型</param>
        /// <param name="cmdParms">参数集</param>
        /// <param name="tran">事务</param>
        /// <returns></returns>
        public static object ExecuteScalar(SqlTransaction tran, SqlConnection conn, string cmdText, CommandType cmdType, params SqlParameter[] cmdParms)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                //conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                cmd.Transaction = tran;
                if (cmdParms != null)
                {
                    foreach (SqlParameter parm in cmdParms)
                    {
                        cmd.Parameters.Add(parm);
                    }
                }
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
            }
        }

        /// <summary>
        /// 执行SQL语句并返回DataReader对象
        /// </summary>
        /// <param name="cmdText">sql字符串</param>
        /// <param name="cmdType">sql类型</param>
        /// <param name="cmdParms">参数集</param>
        /// <returns></returns>
        public static SqlDataReader returnDataReader(string cmdText, CommandType cmdType, params SqlParameter[] cmdParms)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            return returnDataReader(conn, cmdText, cmdType, cmdParms);
        }

        /// <summary>
        /// 执行SQL语句并返回DataReader对象
        /// </summary>
        /// <param name="conn">SqlConnection</param>
        /// <param name="cmdText">sql字符串</param>
        /// <param name="cmdType">sql类型</param>
        /// <param name="cmdParms">参数集</param>
        /// <returns></returns>
        public static SqlDataReader returnDataReader(SqlConnection conn, string cmdText, CommandType cmdType, params SqlParameter[] cmdParms)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);

            //SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand();
            try
            {
                //conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = cmdText;
                cmd.CommandType = cmdType;
                if (cmdParms != null)
                {
                    foreach (SqlParameter parm in cmdParms)
                    {
                        cmd.Parameters.Add(parm);
                    }
                }
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return sdr;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
            }
        }

        /// <summary>
        /// 执行SQL语句并返回DataSet对象
        /// </summary>
        /// <param name="cmdText">sql字符串</param>
        /// <param name="cmdType">sql类型</param>
        /// <param name="cmdParms">参数集</param>
        public static DataSet returnDataSet(string cmdText, CommandType cmdType, params SqlParameter[] cmdParms)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            return returnDataSet(conn, cmdText, cmdType, cmdParms);
        }

        /// <summary>
        /// 执行SQL语句并返回DataSet对象
        /// </summary>
        /// <param name="conn">SqlConnection</param>
        /// <param name="cmdText">sql字符串</param>
        /// <param name="cmdType">sql类型</param>
        /// <param name="cmdParms">参数集</param>
        public static DataSet returnDataSet(SqlConnection conn, string cmdText, CommandType cmdType, params SqlParameter[] cmdParms)
        {
            //SqlConnection 
            if (conn == null)
                conn = new SqlConnection(strConn);

            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                //conn.Open();
                sda.SelectCommand = new SqlCommand();
                sda.SelectCommand.Connection = conn;
                sda.SelectCommand.CommandText = cmdText;
                sda.SelectCommand.CommandType = cmdType;
                if (cmdParms != null)
                {
                    foreach (SqlParameter parm in cmdParms)
                    {
                        sda.SelectCommand.Parameters.Add(parm);
                    }
                }
                DataSet ds = new DataSet();
                sda.Fill(ds, "ds");
                return ds;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        #region 构造参数
        /// <summary>
        /// 构造参数
        /// </summary>
        /// <param name="ParaName">名称</param>
        /// <param name="stype">类型</param>
        /// <param name="size">长度</param>
        /// <param name="value">对应值</param>
        /// <returns></returns>
        public static SqlParameter MakeParam(string ParaName, SqlDbType stype, int size, object value)
        {
            SqlParameter para = new SqlParameter(ParaName, value);
            para.SqlDbType = stype;
            para.Size = size;
            para.Value = value;
            return para;
        }

        /// <summary>
        /// 构造参数
        /// </summary>
        /// <param name="ParaName">名称</param>
        /// <param name="stype">类型</param>
        /// <param name="value">对应值</param>
        /// <returns></returns>
        public static SqlParameter MakeParam(string ParaName, SqlDbType stype, object value)
        {
            SqlParameter para = new SqlParameter(ParaName, value);
            para.SqlDbType = stype;
            para.Value = value;
            return para;
        }
        #endregion
    }
}