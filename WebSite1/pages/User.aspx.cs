using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
public partial class pages_User : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie cooki = Request.Cookies["Preferences"];
        if(cooki!=null)
        {
            Session["na"] = cooki["name"];
        }
     
        if(Session["na"]!=null)
        {

        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["Preferences"];
        cookie = new HttpCookie("Preferences");
        cookie.Expires = DateTime.Now.AddDays(-1);
        Response.Cookies.Add(cookie);
        Session.Abandon();
        Response.Redirect("Login.aspx");
        
    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        if(RadioButton1.Checked)
        {
            Response.Redirect("Two.aspx");
        }
        if(RadioButton2.Checked)
        {
            Response.Redirect("History.aspx");
        }
    }
}