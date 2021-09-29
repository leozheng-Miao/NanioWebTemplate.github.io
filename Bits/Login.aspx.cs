using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Bits
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName != null && txtPwd != null)
            {
                int result;
                try
                {
                    string sql = "select count(*) from T_User where " +
                    "UserName=@UserName and UserPwd=@UserPwd";
                    SqlParameter[] ps = new SqlParameter[2];
                    ps[0] = SqlHelper.MakeParam("@UserName", SqlDbType.NVarChar, 50, txtName.Text);
                    ps[1] = SqlHelper.MakeParam("@UserPwd", SqlDbType.NVarChar, 50, txtPwd.Text);
                    result = Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text, ps));
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                if (result == 1)
                {  
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Alert",
                    "<script>alert('Wrong user name or password！')</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Alert",
                    "<script>alert('Username or password is empty！')</script>");
            }
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sign.aspx");
        }
    }
}