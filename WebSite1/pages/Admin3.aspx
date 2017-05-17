<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin3.aspx.cs" Inherits="pages_Admin3" %>

<%@ Register Src="~/controls/footer.ascx" TagPrefix="uc1" TagName="footer" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <link href="../Styles/Style.css" rel="stylesheet" />
    <style>
        .auto
        {
            border:solid 2px black;
        }
        .auto th 
        {
            border:solid 2px black;
            width:110px;
        }
        .auto td
        {
            border:solid 2px black;
            width:110px;
            overflow:auto;
        }
        .auto-style23 {
            color: #FF0000;
        }
        .auto-style24 {
            color: #66FF33;
        }
        .auto-style25 {
            color: #0066FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">

            <div style="width: 900px">
    <div style="height: 121px; background-color: #00CCFF; width: 900px; margin-left: 0px;">
           
        <div style="height: 121px; width: 121px; background-color: #CCFFFF; float:left;font-size:35px; font-weight: 700;">
            <img src="../Images/logo.jpg" />
        </div>
             <div style="float:left; width: 779px; height: 88px; background-color: #66FF66;font-size:50px; font-weight: 700;">
                     Mrittika Pharmaceuticals Ltd.
             </div>
              <span class="auto-style6"><strong>Address:Amar ekushey Hall, Kuet</strong></span>
     </div>      
 
    <div style="height: 35px; background-color: #FFFFFF; width: 904px;">   
        <a href="Default.aspx"><div class="auto-style5">Home</div></a>
        <a href="Products.aspx"><div class="auto-style5">Products</div></a>
         <a href="Latest_news.aspx"><div class="auto-style5">Latest news</div></a> 
        <a href="Contact_us.aspx"><div class="auto-style5">Contact Us</div></a>
        <a href="Login.aspx"><div class="auto-style5">User Login</div></a>           
        </div>
    </div>
        <div style="height: 30px; width: 133px; margin-left: 736px; margin-top: 20px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" Width="100px" />
        </div>

        <div style="height: 310px;width:650px; margin-top: 25px; margin-left: 120px; margin-right: 120px;overflow:auto;border:solid 2px red;">
            
            <span class="auto-style24">INSERT</span><br />

            Product Name:
            <asp:TextBox ID="TextBox1" runat="server" Width="100px"></asp:TextBox>
            <br />

            Unit Price:
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 29px" Width="100px"></asp:TextBox>
            <br />

            In Stock:
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 40px" Width="100px"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Insert" style="margin-left: 15px" />
            <br /><span class="auto-style23">DELETE</span><br />
            Product Name:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" style="margin-left: 100px" />
            <br />
            <span class="auto-style25">UPDATE</span><br />
            <br />Product Name:
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            Unit Price:
            <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 35px"></asp:TextBox>
&nbsp;<br />
            <asp:Button ID="Button4" runat="server" Text="Update" OnClick="Button4_Click" style="margin-left: 80px" />
            

        </div>
        <div style="margin-top: 50px">
            <uc1:footer runat="server" ID="footer" />
        </div>
        
    </div>
    </form>
</body>
</html>
