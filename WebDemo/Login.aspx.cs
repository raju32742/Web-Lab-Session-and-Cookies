using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Configuration;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    public String Str;
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie userCookie;
        userCookie = Request.Cookies["Login"];
        if (userCookie != null)
        {
            if (!userCookie.Value.Equals(-1))
            {
                Session.Clear();
                Session["UserName"] = TextBoxUNLogin.Text;
                userCookie["UserName"] = TextBoxUNLogin.Text;
                Response.Redirect("success.aspx");

            }
        }

    }
    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        int temp = 0;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Demo_DBMS"].ConnectionString);
        conn.Open();
        string checkuser = "select count(*) from UserI where UserName='" + TextBoxUNLogin.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        conn.Close();
        if (temp > 0)
        {
            conn.Open();
            string checkPasswordQuery = "select Password from UserI where UserName='" + TextBoxUNLogin.Text + "'";
            SqlCommand passComm = new SqlCommand(checkPasswordQuery, conn);
            string password = passComm.ExecuteScalar().ToString().Replace(" ", "");






            if (password == TextBoxPass.Text)
            {
                Session["UserName"] = TextBoxUNLogin.Text;

                Response.Write("Password is correct");
                Response.Redirect("success.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "mykey", "f2()", true);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "mykey", "f1()", true);
        }


    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {


        HttpCookie usercookie = new HttpCookie("Login");
        usercookie["UserName"] = TextBoxUNLogin.Text;
        usercookie.Expires = DateTime.Now.AddMinutes(10);
        Response.Cookies.Add(usercookie);

    }

}