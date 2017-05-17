<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_log.aspx.cs" Inherits="pages_Admin_log" %>

<%@ Register Src="~/controls/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="~/controls/Header.ascx" TagPrefix="uc1" TagName="Header" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
    <link href="../Styles/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
        <uc1:Header runat="server" ID="Header" />
        <div style="height: 220px; margin-left: 150px; margin-right: 150px; margin-top: 50px; background-color: #3399FF; color: #FFFFFF;">
            <span class="auto-style16"><strong>ADMIN LOGIN</strong></span>
            <br />
            <br />
            Email:<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 26px"></asp:TextBox>
            <br />
            Password:<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <span style="margin-left:100px">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Remember me??" />
            </span>
            <br />

            <asp:Button ID="Button1" runat="server" style="margin-left: 131px;border-radius:55px; height: 26px;" Text="Login" Width="79px" OnClick="Button1_Click" />

            
            
            
        </div>
                <div style="height:30px; margin-left: 150px; margin-right: 150px; margin-top: 0px; background-color: #3399FF; color: #FFFFFF;">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
        <div style="margin-top: 50px">
            <uc1:footer runat="server" ID="footer" />
        </div>
        
    </div>
    </form>
</body>
</html>