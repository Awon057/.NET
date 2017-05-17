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
public partial class pages_Two : System.Web.UI.Page
{

    public static string[] serial_info = new string[101];
    public static string[] name = new string[101];
    public static string[] price = new string[101];
    public static string[] stock = new string[101];
    public static string[] total = new string[101];

    public static string roll_no;

    public static int i;
    public static int show_money;

    public static CheckBox[] check_box = new CheckBox[101];
    public static TextBox[] text = new TextBox[101];
    //public JavaScriptSerializer javaSerial = new JavaScriptSerializer();


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
   

        roll_no = (string)(Session["na"]);

        try
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

           // Identity();

            SqlCommand comm = new SqlCommand("SELECT  * FROM product ", conn);
            SqlDataReader reader = comm.ExecuteReader();

            i = 1;

            while (reader.Read())
            {
                serial_info[i] = reader[0].ToString();
                name[i] = reader[1].ToString();
                price[i] = reader[2].ToString();
                stock[i] = reader[3].ToString();

                i++;
            }

            reader.Close();
            
            HtmlTable main_table = new HtmlTable();
            main_table.ID = "info_table";
            main_table.Attributes.Add("style", "background:#663300;border:1px solid #443449;width:500px;cellpadding:0");


            HtmlTableRow r = new HtmlTableRow();

            HtmlTableCell c = new HtmlTableCell();
            c.InnerHtml = "<h2>Select</h2>";
            c.Attributes.Add("style", "border:2px solid green;text-align:center");
            r.Cells.Add(c);

            HtmlTableCell c1 = new HtmlTableCell();
            c1.InnerHtml = "<h2>Product Name</h2>";
            c1.Attributes.Add("style", "border:2px solid green;text-align:center");
            r.Cells.Add(c1);

            HtmlTableCell c2 = new HtmlTableCell();
            c2.InnerHtml = "<h2>Unit Price</h2>";
            c2.Attributes.Add("style", "border:2px solid green;text-align:center");
            r.Cells.Add(c2);

            HtmlTableCell c3 = new HtmlTableCell();
            c3.InnerHtml = "<h2>Available</h2>";
            c3.Attributes.Add("style", "border:2px solid green;text-align:center");
            r.Cells.Add(c3);

            HtmlTableCell c4 = new HtmlTableCell();
            c4.InnerHtml = "<h2>Amount</h2>";
            c4.Attributes.Add("style", "border:2px solid green;text-align:center");
            r.Cells.Add(c4);

            main_table.Rows.Add(r);

            Panel1.Controls.Add(main_table);

            for (int j = 1; j < i; j++)
            {
                r = new HtmlTableRow();

                c = new HtmlTableCell();
                c1 = new HtmlTableCell();
                c2 = new HtmlTableCell();
                c3 = new HtmlTableCell();
                c4 = new HtmlTableCell();

                text[j] = new TextBox();
                text[j].ID = "text" + Convert.ToString(j);
                //text[j].AutoPostBack = true;
                text[j].Text = "";

                check_box[j] = new CheckBox();
                check_box[j].ID = "dm_checkbox" + Convert.ToString(j);

                check_box[j].AutoPostBack = true;
                check_box[j].CheckedChanged += show_CheckedChanged;
                //check_box[j].Attributes.Add("onclick", "return faltu('" + check_box[j].ClientID + "','" + selected_info.ClientID + "','" + price[j] + "');");
                c3.Controls.Add(check_box[j]);
                c3.Attributes.Add("style", "border:2px solid green;width:50px;padding-left:30px");
                r.Cells.Add(c3);


                c.InnerHtml = name[j];
                c.Attributes.Add("style", "border:2px solid green;text-align:center");
                r.Cells.Add(c);

                c1.InnerHtml = price[j];
                c1.Attributes.Add("style", "width:120px;border:2px solid green;text-align:center");
                r.Cells.Add(c1);

                c2.InnerHtml = stock[j];
                c2.Attributes.Add("style", "border:2px solid green;text-align:center");
                r.Cells.Add(c2);


                /*text[j] = new TextBox();
                text[j].ID = "text" + Convert.ToString(j);
                //text[j].AutoPostBack = true;
                text[j].Text = "";*/
                c4.Controls.Add(text[j]);
                c4.Attributes.Add("style", "border:1px solid green;width:50px;padding-left:30px");
                r.Cells.Add(c4);

                main_table.Rows.Add(r);

                Panel1.Controls.Add(main_table);
            }

            conn.Close();
        }
        catch (SqlException ex)
        {
            mess.Text = ex.Message;
        }


    }





    protected void paid_Click(object sender, EventArgs e)
    {
        if (check_order() == true)
        {
              

            int hall_pay = 0;

            for (int j = 1; j < i; j++)
            {

                if (check_box[j].Checked == true)
                {
                    int per_dues = Convert.ToInt32(price[j]);
                    hall_pay = hall_pay + per_dues;
                }
            }


         
           
                for (int j = 1; j < i; j++)
                {
                    if (check_box[j].Checked == true)
                    {
                       
                        upadate_status(j);
                    }
                }
                mess.Text = "*******Order is completed.Wait for Admin response**************";
          
            Panel1.Visible = false;
            paid.Visible = false;
        }
        else
            label.Text = "Please,pay the previous dues first...";
    }

    bool check_order()
    {
        return true;
        for (int j = 2; j < i; j++)
        {
            if (check_box[j - 1].Checked == true)
                continue;
            else
                return false;
        }
        return true;
    }

   
    void upadate_status(int j)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        string quantity = "1";
        if (text[j].Text == "")
            quantity = "1";
        else
            quantity = text[j].Text.ToString();
        SqlCommand commd2 = new SqlCommand("INSERT INTO Store  VALUES('" + Session["na"].ToString() + "','" + name[j].ToString() + "','" + text[j].Text.ToString() + "','" + (Convert.ToInt32(price[j]) * Convert.ToInt32(quantity)) + "','" + DateTime.Now.ToString() + "','pending') ", conn);
        SqlDataReader reader2 = commd2.ExecuteReader();
        reader2.Close();

        conn.Close();


    }

    void Identity()
    {
        string fn = "", ln = "";
        string connectionString = ConfigurationManager.ConnectionStrings["OPSConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        SqlCommand new_comm = new SqlCommand("SELECT First_Name,Last_Name FROM register_student WHERE Roll='" + roll_no + "'", conn);
        SqlDataReader new_reader = new_comm.ExecuteReader();

        if (new_reader.Read())
        {
            fn = new_reader["First_Name"].ToString();
            ln = new_reader["Last_Name"].ToString();
        }

        //balance_info.Text = fn + "  " + ln;

        new_reader.Close();
        conn.Close();
    }

    void update(int hall_pay)
    {
        try
        {
            string withdraw, money = "";
            int save_taka = 0, withdraw_taka, total_taka = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["OPSConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand comm = new SqlCommand("SELECT balance FROM amount WHERE Roll='" + roll_no + "'", conn);
            SqlDataReader reader = comm.ExecuteReader();

            if (reader.Read())
                money = reader["balance"].ToString();
            else
                money = "";

            reader.Close();


            withdraw = hall_pay.ToString();
            withdraw_taka = Convert.ToInt32(withdraw);
            save_taka = Convert.ToInt32(money);



            total_taka = save_taka - withdraw_taka;

           // balance_info.Text = "The remaining balance is " + total_taka.ToString();

            SqlCommand comm2 = new SqlCommand("UPDATE amount SET balance=" + total_taka.ToString() + " WHERE Roll='" + roll_no + "'", conn);
            SqlDataReader reader2 = comm2.ExecuteReader();
            reader2.Close();

            conn.Close();
        }
        catch (SqlException ex)
        {
            mess.Text = ex.Message;
        }
    }
    protected void show_CheckedChanged(object sender, EventArgs e)
    {
        selected_info.Text = "True";
        int showing_money = 0;
        bool flag = false;
        string quantity = "1";

        for (int j = 1; j < i; j++)
        {


            if (check_box[j].Checked == true)
            {
                flag = true;

                if (text[j].Text == "")
                    quantity = "1";
                else
                quantity = text[j].Text.ToString();

                showing_money = showing_money + (Convert.ToInt32(price[j]) * Convert.ToInt32(quantity));

                selected_info.Text = "You Have Selectd dues : " + showing_money.ToString() + "Taka";
            }
            else
            {
                text[j].Text = "";
            }
           
            if (flag == false)
                selected_info.Text = "";


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
    protected void Button2_Click(object sender, EventArgs e)
    {
        /* bool atLeastOneRowDeleted = false;
         // Iterate through the Products.Rows property
         foreach (DataList row in DataList1.P_)
         {
             // Access the CheckBox
             CheckBox cb = (CheckBox)row.FindControl("ProductSelector");
             if (cb != null && cb.Checked)
             {
                 // Delete row! (Well, not really...)
                 atLeastOneRowDeleted = true;
                 // First, get the ProductID for the selected row
                 int productID = 
                     Convert.ToInt32(Products.DataKeys[row.RowIndex].Value);
                 // "Delete" the row
                 DeleteResults.Text += string.Format(
                     "This would have deleted ProductID {0}<br />", productID);
             }
         }
         // Show the Label if at least one row was deleted...
         DeleteResults.Visible = atLeastOneRowDeleted;*/
    }
}