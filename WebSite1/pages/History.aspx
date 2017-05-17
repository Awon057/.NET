<%@ Page Language="C#" AutoEventWireup="true" CodeFile="History.aspx.cs" Inherits="pages_History" %>

<%@ Register Src="~/controls/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/controls/footer.ascx" TagPrefix="uc1" TagName="footer" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User</title>
    <link href="../Styles/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
    <div>
        <uc1:Header runat="server" ID="Header" />
    </div>
        <div style="height: 30px; width: 133px; margin-left: 736px; margin-top: 20px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" Width="100px" />
        </div>
        <div style="height: 310px;width:515px; margin-top: 35px; margin-left: 150px; margin-right: 120px; overflow:auto; border:solid 2px red;">
            <asp:Panel ID="history_panel" runat="server">

            </asp:Panel>
            <asp:Label ID="mess" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <uc1:footer runat="server" ID="footer" />
        </div>
    </div>
    </form>
</body>
</html>