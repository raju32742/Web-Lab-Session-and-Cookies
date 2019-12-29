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

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            // nothing
        }
    }

    public void TextBoxPASS_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        int temp = 0;
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Demo_DBMS"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from UserI where UserName='" + TextBoxUN.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            temp = Convert.ToInt32(com.ExecuteScalar().ToString());

            if (temp > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "mykey", "f1()", true);

            }

            conn.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Error" + ex.ToString());
        }


        if (temp == 0)
        {
            try
            {
                
                    string cs = ConfigurationManager.ConnectionStrings["Demo_DBMS"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(cs))
                    {

                        SqlCommand cmd = new SqlCommand("spUserI", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UN", TextBoxUN.Text);
                        cmd.Parameters.AddWithValue("@EM", TextBoxEM.Text);
                        cmd.Parameters.AddWithValue("@PA", TextBoxPASS.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "mykey", "f2()", true);
                        con.Close();


                    }
                }


            catch (Exception ex)
            {
                Response.Write("Error" + ex.ToString());
            }
        }
    }

}