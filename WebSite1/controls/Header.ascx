<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Header.ascx.cs" Inherits="controls_Header" %>


<link href="../Styles/Style.css" rel="stylesheet" />
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
    <asp:LinkButton ID="Login" href="Login.aspx" runat="server"><div  class="l" >Login</div></asp:LinkButton>
    <asp:LinkButton ID="Logout" href="User.aspx" runat="server"><div  class="l" >User</div></asp:LinkButton>
        
         
    </div>
</div>