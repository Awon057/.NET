<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Latest_news.aspx.cs" Inherits="pages_Latest_news" %>

<%@ Register Src="~/controls/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="~/controls/Header.ascx" TagPrefix="uc1" TagName="Header" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>latest news</title>
    <link href="../Styles/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
        <uc1:Header runat="server" ID="Header" />

        <div style="height: 250px; width: 727px; color: #FFFFFF; margin-left: 75px; margin-top: 35px; background-color: #999999;font-size:20px;text-align:left">
            <ul>
                <li style="font-weight: 700">Today a campaign is going in dhaka.</li>
                <li style="font-weight: 700">Our company share price goes high.</li>
            </ul></div>
        <div style="margin-top: 50px">
            <uc1:footer runat="server" ID="footer" />
        </div>
        
    </div>
    </form>
</body>
</html>
