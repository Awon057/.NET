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
using System.Collections;

public partial class pages_Admin1 : System.Web.UI.Page
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



        ItemsList.ItemDataBound += new DataListItemEventHandler(this.Item_Bound);

        // Load sample data only once, when the page is first loaded.
        if (!IsPostBack)
        {
            ItemsList.DataSource = CreateDataSource("show");
            ItemsList.DataBind();
        }

    }
    ICollection CreateDataSource(string s)
    {

        // Create sample data for the DataList control.
        DataTable dt = new DataTable();
        DataRow dr;

        // Define the columns of the table.
        dt.Columns.Add(new DataColumn("id", typeof(String)));
        dt.Columns.Add(new DataColumn("p_id", typeof(String)));
        dt.Columns.Add(new DataColumn("quantity", typeof(String)));
        dt.Columns.Add(new DataColumn("totalcost", typeof(String)));
        dt.Columns.Add(new DataColumn("time", typeof(String)));
        dt.Columns.Add(new DataColumn("flag", typeof(String)));


        // Populate the table with sample values.
        /*for (int i = 0; i < 9; i++) 
        {
           dr = dt.NewRow();

           dr[0] = i;
           dr[1] = "Description for item " + i.ToString();
           dr[2] = 1.23 * (i + 1);

           dt.Rows.Add(dr);
        }*/
        using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ToString()))
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * From [Store]", cn);
            SqlDataReader drd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (drd.Read())
            {

                if (drd["flag"].ToString() == "pending")
                {
                    dr = dt.NewRow();
                    dr[0] = drd[0].ToString();
                    dr[1] = drd[1].ToString();
                    dr[2] = drd[2].ToString();
                    dr[3] = drd[3].ToString();
                    dr[4] = drd[4].ToString();
                    dr[5] = drd[5].ToString();
                    dt.Rows.Add(dr);
                }

            }

        }
        DataView dv = new DataView(dt);
        return dv;
    }
    void Item_Bound(Object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {


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
    protected void btnAddFriend_Click(object sender, EventArgs e)
    {
        Button btnAddFriend = sender as Button;
        string userId = btnAddFriend.CommandArgument;
        string f = "Complete";
        using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ToString()))
        {
            cn.Open();
            SqlCommand cmd1 = new SqlCommand("UPDATE [Store] SET flag='" + f + "' WHERE id='" + userId + "'", cn);
            SqlDataReader rdr = cmd1.ExecuteReader(CommandBehavior.CloseConnection);
            cn.Close();
        }
        Response.Redirect("Admin1.aspx");
    }
    protected void btndeletFriend_Click(object sender, EventArgs e)
    {
        Button btndeletFriend = sender as Button;
        string userId = btndeletFriend.CommandArgument;
        using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ToString()))
        {
            cn.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM [Store] WHERE id='" + userId + "'", cn);
            SqlDataReader rdr1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection);


            cn.Close();
        }
        Response.Redirect("Admin1.aspx");
    }
}