using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class controls_Header : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["na"]!=null)
        {
            Logout.Visible = true;
            Login.Visible = false;
        }
        else
        {
            Logout.Visible = false;
            Login.Visible = true;
        }
    }
}