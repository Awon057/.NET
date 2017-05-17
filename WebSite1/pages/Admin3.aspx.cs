using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;

public partial class pages_Admin3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie cooki = Request.Cookies["Preferences"];
        if (cooki != null)
        {
            Session["na"] = cooki["name"];
        }

        if (Session["na"] != null)
        {

        }
        else
        {
            Response.Redirect("Admin_log.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ToString()))
        {
            cn.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO [product] ([P_name],[Unit_price],[in_stock]) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "') ", cn);
            SqlDataReader rdr1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection);
            Response.Write(TextBox1 + " " + TextBox2 + " " + TextBox3 + " are Inserted");

            cn.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["Preferences"];
        cookie = new HttpCookie("Preferences");
        cookie.Expires = DateTime.Now.AddDays(-1);
        Response.Cookies.Add(cookie);
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string s=TextBox4.Text;
        using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ToString()))
        {
            cn.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM [product] WHERE P_name='" +s+ "'", cn);
            SqlDataReader rdr1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection);
            Response.Write(TextBox1 + " " + TextBox2 + " " + TextBox3 + " are Inserted");

            cn.Close();
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string s = TextBox5.Text;
        string f = TextBox6.Text;
        using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ToString()))
        {
            cn.Open();
            SqlCommand cmd1 = new SqlCommand("UPDATE [product] SET Unit_price='" + f + "' WHERE P_name='" + s + "'", cn);
            SqlDataReader rdr1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection);
            Response.Write(TextBox5 +  " is upated");

            cn.Close();
        }
    }
}