using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_Admin2 : System.Web.UI.Page
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
    protected void Button2_Click1(object sender, EventArgs e)
    {
        if (RadioButton1.Checked)
        {
            Response.Redirect("Admin.aspx");
        }
        if (RadioButton2.Checked)
        {
            Response.Redirect("Admin1.aspx");
        }
        if(RadioButton3.Checked)
        {
            Response.Redirect("Admin3.aspx");
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
}