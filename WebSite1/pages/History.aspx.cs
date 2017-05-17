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


public partial class pages_History : System.Web.UI.Page
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
            Response.Redirect("Login.aspx");
        }
        show_content();
    }


    void show_content()
    {
        string info = (string)Session["na"];

        string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        try
        {

            SqlCommand comm = new SqlCommand("SELECT  P_id,Quantity,Total_Cost,time,flag FROM Store WHERE Id='" + info + "'", conn);
            SqlDataReader reader = comm.ExecuteReader();

            HtmlTable main_table = new HtmlTable();
            main_table.ID = "info_table";
            main_table.Attributes.Add("style", "background:#663300;border:1px solid #443449;width:500px;cellpadding:0");


            HtmlTableRow r = new HtmlTableRow();

            HtmlTableCell c = new HtmlTableCell();
            c.InnerHtml = "<h2>Id</h2>";
            c.Attributes.Add("style", "border:1px solid green;text-align:center");
            r.Cells.Add(c);

            HtmlTableCell c1 = new HtmlTableCell();
            c1.InnerHtml = "<h2>Product</h2>";
            c1.Attributes.Add("style", "border:1px solid green;text-align:center");
            r.Cells.Add(c1);

            HtmlTableCell c2 = new HtmlTableCell();
            c2.InnerHtml = "<h2>Quantity</h2>";
            c2.Attributes.Add("style", "border:1px solid green;text-align:center");
            r.Cells.Add(c2);

            HtmlTableCell c3 = new HtmlTableCell();
            c3.InnerHtml = "<h2>Cost</h2>";
            c3.Attributes.Add("style", "border:1px solid green;text-align:center");
            r.Cells.Add(c3);

            HtmlTableCell c4 = new HtmlTableCell();
            c4.InnerHtml = "<h2>Time</h2>";
            c4.Attributes.Add("style", "border:1px solid green;text-align:center");
            r.Cells.Add(c4);

            HtmlTableCell c5 = new HtmlTableCell();
            c5.InnerHtml = "<h2>Flag</h2>";
            c5.Attributes.Add("style", "border:1px solid green;text-align:center");
            r.Cells.Add(c5);

            main_table.Rows.Add(r);

            history_panel.Controls.Add(main_table);

            while (reader.Read())
            {
                r = new HtmlTableRow();

                c = new HtmlTableCell();
                c1 = new HtmlTableCell();
                c2 = new HtmlTableCell();
                c3 = new HtmlTableCell();
                c4 = new HtmlTableCell();
                c5 = new HtmlTableCell();

                c.InnerHtml = info;
                c.Attributes.Add("style", "border:1px solid green;text-align:center");
                r.Cells.Add(c);

                c1.InnerHtml = reader["P_id"].ToString();
                c1.Attributes.Add("style", "border:1px solid green;text-align:center");
                r.Cells.Add(c1);

                c2.InnerHtml = reader["Quantity"].ToString();
                c2.Attributes.Add("style", "border:1px solid green;text-align:center");
                r.Cells.Add(c2);

                c3.InnerHtml = reader["Total_Cost"].ToString();
                c3.Attributes.Add("style", "border:1px solid green;text-align:center");
                r.Cells.Add(c3);

                c4.InnerHtml = reader["Time"].ToString();
                c4.Attributes.Add("style", "border:1px solid green;text-align:center");
                r.Cells.Add(c4);

                c5.InnerHtml = reader["flag"].ToString();
                c5.Attributes.Add("style", "border:1px solid green;text-align:center");
                r.Cells.Add(c5);

                main_table.Rows.Add(r);

                history_panel.Controls.Add(main_table);
            }
            reader.Close();

            conn.Close();
        }
        catch (SqlException ex)
        {
            mess.Text = ex.Message;
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
}