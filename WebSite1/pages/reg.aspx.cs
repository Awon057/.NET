using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

public partial class pages_reg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ToString()))
        {
            cn.Open();


            SqlCommand cmd1 = new SqlCommand("INSERT INTO [Table] ([Name],[Store_name],[Store_address],[Phone],[Email],[Password],[flag]) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','Pending') ", cn);
            SqlDataReader rdr = cmd1.ExecuteReader(CommandBehavior.CloseConnection);

            Response.Redirect("Registered.aspx");

            cn.Close();
        }
    }
}