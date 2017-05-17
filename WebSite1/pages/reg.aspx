<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reg.aspx.cs" Inherits="pages_reg" %>

<%@ Register Src="~/controls/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/controls/footer.ascx" TagPrefix="uc1" TagName="footer" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 550px;
            border: solid red;
        border-width: 1px;
        }
        .auto-style2 {
            width: 162px;
        }
        .auto-style3 {
            width: 130px;
        }
        .auto-style4 {
            width: 280px;
            color:red
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" onsubmit="return Validation(this)">
        <script src="JavaScript.js"></script>
        <div class="main">

          <div>
            <uc1:Header runat="server" ID="Header" />
         </div>
        <div style="height: 305px; margin-top: 30px; width: 586px; margin-left: 170px;text-align:left;">
            <span style="font-size:x-large;">
                Registration
            </span>
            <div style="text-align:left">

                <table align="center" class="auto-style1">
    <tr>
        <td class="auto-style2">Name:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style4">
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </td>
        
    </tr>
    <tr>
        <td class="auto-style2">Store Name:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style4">
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </td>
        
    </tr>
    <tr>
        <td class="auto-style2">Store Address:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style4">
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </td>
        
    </tr>
    <tr>
        <td class="auto-style2">Contact Number:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style4">
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </td>
    </tr>

    <tr>
        <td class="auto-style2">Email:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox>
        </td>
        <td class="auto-style4">
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Password:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox6" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td class="auto-style4">
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Confirm Password:</td>
        <td class="auto-style3">
            <asp:TextBox ID="TextBox7" runat="server" TextMode="Password" Height="21px"></asp:TextBox>
        </td>
        <td class="auto-style4">
            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
        </td>
       
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">
            <asp:Button ID="Button1" runat="server" style="margin-left: 44px" Text="Submit" Width="80px" OnClick="Button1_Click" />
        </td>
        <td class="auto-style4">
            </td>
    </tr>
    
</table>
            </div>
            
        </div>
        <div style="margin-top: 57px">
            <uc1:footer runat="server" ID="footer" />
        </div>
        </div>
  
    </form>
</body>
</html>
