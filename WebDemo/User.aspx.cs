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
public partial class User : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            string css = ConfigurationManager.ConnectionStrings["Demo_DBMS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(css))
            {

                SqlCommand cmd1 = new SqlCommand("Select * from UserI where UserName = '" + Request.Cookies["Login"]["UserName"].ToString() + "' ", conn);

                conn.Open();
                using (SqlDataReader rd = cmd1.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        LabelUN.Text = rd["UserName"].ToString();
                      
                    }
                }
                conn.Close();

            }

        }

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("success.aspx");
    }

}