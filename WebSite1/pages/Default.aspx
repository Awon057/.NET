<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="pages_Default" %>

<%@ Register Src="~/controls/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="~/controls/Header.ascx" TagPrefix="uc1" TagName="Header" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="../Styles/Style.css" rel="stylesheet" />
    <link href="css/ninja-slider.css" rel="stylesheet" type="text/css" />
    <script src="js/ninja-slider.js" type="text/javascript"></script>
    
</head>
<body >
    <form id="form1" runat="server" >
  <div class="main">

      <uc1:Header runat="server" ID="Header" />

          <div style="height: 240px; margin-top: 15px; background-color: #0066FF; width: 900px;">
                 <div id="ninja-slider" style="width:600px; height:210px;">
                                 <ul>
                                          <li><img src="Image/slide1.jpg" /></li>
                                          <li><img src="Image/Pharmaceutical%20Companies%20in%20Gurgaon.jpg" /></li>
                                          
                                         </ul>
                                    </div>
         </div>
      <div class="auto-style12">
          About Us
          <div style=" height: 115px; margin:0px;background-color:#CCCCFF; overflow:auto;width:900px">
<p style="color:blue; text-decoration:none;font-size:20px;">
              MRITTIKA today symbolizes a name – a state of mind. But its journey to the growth and prosperity has been no bed of roses.
               From the inception in 2014, it has today burgeoned into one of the top line conglomerates in Bangladesh. MRITTIKA Pharmaceuticals Ltd.,
                the flagship company, is holding the strong leadership position in the pharmaceutical industry of Bangladesh since 2014 and is now on
                 its way to becoming a high performance global player.</br></br>

                 MRITTIKA Pharmaceuticals Limited is the largest pharmaceutical company in Bangladesh and it has been continuously in the 1st position
                  among all national and multinational companies since 2014. It was established in 2014 and converted into a public limited company in 2014.
                   The sales turnover of SPL was more than Taka 11.46 Billion (US$ 163.71 million) with about 16.43% market share  having
                    a growth rate of about 16.72%.
             </p>
               
          </div>
         
      </div>
      <div style="margin-top: 20px">
          <uc1:footer runat="server" ID="footer" />
      </div>
      
    
  </div>
    </form>
    <script type="text/javascript" src="js/jquery-1.9.0.min.js"></script>
</body>
</html>
