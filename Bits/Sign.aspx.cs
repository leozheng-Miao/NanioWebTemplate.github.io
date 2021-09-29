using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Bits
{
    public partial class Sign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnReg_Click(object sender, EventArgs e)
        {

            //取配置文件中ConnectionStrings这个节点里
            //name为connStr的ConnectionString属性
            string strConn =
                ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            Response.Write(strConn);
            //实例化一个数据库连接，并打开数据库
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            SqlCommand cmd = new SqlCommand();//实例化数据库

            try
            {

                cmd.Connection = conn;
                cmd.CommandText = "insert into T_User values(@userName ,@userPwd)";
                cmd.CommandType = CommandType.Text;
                SqlParameter[] paras = new SqlParameter[2];
                paras[0] = new SqlParameter("@userName", SqlDbType.NVarChar, 50);
                paras[0].Value = txtName2.Text;

                paras[1] = new SqlParameter("@userPwd", SqlDbType.NVarChar, 50);
                paras[1].Value = txtPwd2.Text;


                foreach (SqlParameter p in paras)
                {
                    cmd.Parameters.Add(p);
                }


                cmd.ExecuteNonQuery();//只执行sql语句，返回影响行数。

                Response.Write("<script>alert('Registration success！');window.location='Login.aspx';</script>");

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

                conn.Close();

            }
        }
    }
}