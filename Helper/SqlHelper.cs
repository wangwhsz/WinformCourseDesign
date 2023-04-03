using System;
using System.Data;
using System.Data.SqlClient;

namespace Helper
{
    public class SqlHelper
    {
        //连接字符串
        static readonly string  strConn = "Data Source =.; Initial Catalog = User; User ID = sa; Password = 123;Persist Security Info=True;";//使用config配置,便于打包后修改

        /// <summary>
        /// 初始化数据连接
        /// </summary>
        public static SqlConnection InitDataConnection()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = strConn;
            return Conn;
        }        

        /// <summary>
        /// 执行非查询存储过程和SQL语句[增;删;改]
        /// </summary>
        /// <param name="cmdText">SQL语句</param>
        /// <param name="cmd">数据执行命令</param>
        /// <returns>返回影响行数</returns>
        public static int ExecCmd(string cmdText, SqlParameter[] parm = null, SqlCommand cmd = null)
        {
            System.Data.SqlClient.SqlConnection Conn = null;
            bool bAutoClose = false;    //判断是否自动关闭数据连接
            try
            {
                if (cmd == null)
                {
                    bAutoClose = true;
                    Conn = InitDataConnection();
                    cmd = new SqlCommand();
                    cmd.Connection = Conn;
                }

                cmd.CommandText = cmdText;
                cmd.CommandTimeout = 8000;
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }

                if (parm != null)
                {
                    cmd.Parameters.AddRange(parm);
                }

                int nRow = cmd.ExecuteNonQuery();
                return nRow;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (bAutoClose)
                {
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                    if (Conn != null && Conn.State == ConnectionState.Open)
                    {
                        Conn.Close();
                        Conn.Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// 查询并返回结果集的首行首列
        /// </summary>
        /// <param name="cmdText">SQL语句</param>
        /// <param name="parm">参数列表</param>
        /// <param name="cmd">数据执行命令</param>
        /// <returns></returns>
        public static object GetObject(string cmdText, SqlParameter[] parm = null, SqlCommand cmd = null)
        {
            System.Data.SqlClient.SqlConnection Conn = null;
            bool bAutoClose = false;    //判断是否自动关闭数据连接
            try
            {
                if (cmd == null)
                {
                    bAutoClose = true;
                    Conn = InitDataConnection();
                    cmd = new SqlCommand();
                    cmd.Connection = Conn;
                }

                cmd.CommandText = cmdText;
                cmd.CommandTimeout = 8000;
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }

                if (parm != null)
                {
                    cmd.Parameters.AddRange(parm);
                }

                object Result = cmd.ExecuteScalar();
                return Result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (bAutoClose)
                {
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                    if (Conn != null && Conn.State == ConnectionState.Open)
                    {
                        Conn.Close();
                        Conn.Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// 执行查询，返回DataTable对象
        /// </summary>
        /// <param name="cmdText">SQL语句</param>
        /// <param name="parm">参数列表</param>
        /// <param name="cmd">数据执行命令</param>
        /// <returns></returns>
        public static DataTable GetTable(string cmdText, SqlParameter[] parm = null, SqlCommand cmd = null)
        {
            System.Data.SqlClient.SqlConnection Conn = null;
            System.Data.SqlClient.SqlDataAdapter adp = null;
            bool bAutoClose = false;    //判断是否自动关闭数据连接
            try
            {
                if (cmd == null)
                {
                    bAutoClose = true;
                    Conn = InitDataConnection();
                    cmd = new SqlCommand();
                    cmd.Connection = Conn;
                }

                cmd.CommandText = cmdText;
                cmd.CommandTimeout = 8000;
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }

                if (parm != null)
                {
                    cmd.Parameters.AddRange(parm);
                }

                adp = new System.Data.SqlClient.SqlDataAdapter();
                adp.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (adp != null)
                {
                    adp.Dispose();
                }
                if (bAutoClose)
                {
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                    if (Conn != null && Conn.State == ConnectionState.Open)
                    {
                        Conn.Close();
                        Conn.Dispose();
                    }
                }
            }
        }
    }
}