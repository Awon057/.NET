using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class pages_Admin_log : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie cooki = Request.Cookies["Preferences"];
        if (cooki != null)
        {
            Session["na"] = cooki["name"];
            Response.Redirect("Admin2.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

            string n = Convert.ToString("Awon");
            string m = Convert.ToString(TextBox1.Text);

            string p = Convert.ToString("kuet123");
            string q = Convert.ToString(TextBox2.Text);

                if ((p == q) && (m == n))
                {
                    HttpCookie cookie = Request.Cookies["Preferences"];
                    if (CheckBox1.Checked)
                    {
                        cookie = new HttpCookie("Preferences");
                        cookie["name"] = TextBox1.Text;
                        cookie["pw"] = TextBox2.Text;
                        cookie.Expires = DateTime.Now.AddDays(1);
                        Response.Cookies.Add(cookie);
                        Session["na"] = cookie["name"];
                        Session["pss"] = cookie["pw"];

                    }
                    else
                    {
                        Session["na"] = TextBox1.Text;
                        Session["pss"] = TextBox2.Text;
                    }
                    Response.Redirect("Admin2.aspx");
                }
                 else
                 {
                     Label1.Text = "Wrong email or password";
                 }

        }
}