<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registered.aspx.cs" Inherits="pages_Default2" %>

<%@ Register Src="~/controls/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/controls/footer.ascx" TagPrefix="uc1" TagName="footer" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
         <div>
             <uc1:Header runat="server" ID="Header" />
    </div>
        <div style="height: 350px; margin-top: 39px; font-style: italic; color: #FF0000;">
    
            Your Registration is on process.</div>
        <div>
            <uc1:footer runat="server" ID="footer" />
    </div>
    </div>
    </form>
</body>
</html>
