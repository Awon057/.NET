﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="pages_Admin" %>

<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>

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
            <div id="req" style="">
             <asp:DataList id="ItemsList" runat="server" style="margin-left: 5px" >
                 <HeaderTemplate>
                     <table class="auto">
                         <tr>
                             <th>Name</th>
                             <th>Store Name</th>
                             <th>Store Address</th>
                             <th>Phone num</th>
                             <th>Email</th>
                             <th>Permission</th>
                             <th>Denied</th>
                         </tr>
                     </table>
                 </HeaderTemplate>

         <ItemTemplate >
              <table class="auto">

                  <tr>
                   <td > <%# DataBinder.Eval(Container.DataItem, "name") %> </td>
                      <td > <%# DataBinder.Eval(Container.DataItem, "s_name") %> </td>
                      <td > <%# DataBinder.Eval(Container.DataItem, "s_add") %> </td>
                      <td > <%# DataBinder.Eval(Container.DataItem, "ph") %> </td>
                      <td > <%# DataBinder.Eval(Container.DataItem, "mail") %> </td>
                <td  style="text-align:right"><asp:Button Text="Accept" ID="Button1" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "mail") %>' 
                    OnClick="btnAddFriend_Click" runat="server" />
                     <td  style="text-align:right"><asp:Button Text="Cancel" ID="Button2" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "mail") %>' 
                    OnClick="btndeletFriend_Click" runat="server" />
                </td>
                  </tr>
        </table>
         </ItemTemplate>
      </asp:DataList>
            </div>
        </div>
        <div style="margin-top: 50px">
            <uc1:footer runat="server" ID="footer" />
        </div>
        
    </div>
    </form>
</body>
</html>
