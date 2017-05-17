<%@ Page Language="C#" AutoEventWireup="true" CodeFile="contact_us.aspx.cs" Inherits="pages_contact_us" %>

<%@ Register Src="~/controls/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="~/controls/Header.ascx" TagPrefix="uc1" TagName="Header" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact us</title>
    <link href="../Styles/Style.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style19 {
            width: 300px;
            height: 250px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">

        <uc1:Header runat="server" ID="Header" />

        <div style="height: 300px; margin-top: 20px; width: 900px;">

            <div style="float:left; background-image:url('../Images/contact.jpg'); width:250px; height: 300px; margin-left: 22px;">
                </div>
            <div style="float:left; width: 502px; height: 273px; margin-left: 91px; margin-top: 23px;background-color:white;text-align:left">
                <h1 style="margin-left: 40px">Head Office</h1>
                <h4 style="width: 410px; margin-top: 30px;">&nbsp;&nbsp;&nbsp;&nbsp; Amar Ekushey Hall
                    <br />
                    &nbsp;&nbsp;&nbsp;
                    Khulna University of Engineering & Technology
                    <br />
                    <span class="auto-style17"><strong>&nbsp;&nbsp;&nbsp;
                    Mobile No</strong></span>:<span class="auto-style17">01672468928 </span>
                    <br />
                    &nbsp;&nbsp;&nbsp;
                    Email:
                <span class="auto-style17">awonzaman</span>@<span class="auto-style17">yahoo.com</span></h4>

            </div>
        </div>
        <div style="margin-top: 50px">
            <uc1:footer runat="server" ID="footer" />
        </div>
        
    </div>
    </form>
</body>
</html>
