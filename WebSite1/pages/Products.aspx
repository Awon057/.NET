<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="pages_Products" %>

<%@ Register Src="~/controls/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="~/controls/Header.ascx" TagPrefix="uc1" TagName="Header" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products</title>
</head>
<body>
    <form id="form1" runat="server">
     <div class="main">
        
      <div >
          <uc1:Header runat="server" ID="Header" />
      </div>
         <div style="height: 300px; margin-top: 24px">
            
             Search by Generic Name<br />
        <select style="margin-left: 0px"> 
            <option>-- Generic Name --</option>
                <option>Pheniramine Maleate 15 mg/5 ml</option>
                <option>Cetirizine 10 mg</option>
                <option> Cetirizine 5 mg/5 ml</option>
                <option>Cetirizine 2.5 mg/ml</option>
                <option> Fexofenadine 60 mg</option>
                <option> Mebhydroline 50 mg</option>
                <option>  Azithromycin 500 mg</option>
                <option>Bexidal</option>
                <option>Levocetirizine 5 mg</option>
                <option></option>
                
         </select><br />
           A-Z PRODUCT LIST<br />
        <select style="margin-left: 0px; width: 217px;"> 
            
           <option>-- Brand Name --</option>
            <optgroup label="A">
            <option>Aerovil Syrup</option>
            <option>Atrizin Tablet </option>
            <option>Atrizin Syrup</option>
            <option>Atrizin Drops </option>
            <option>Axodin 60 Tablet</option>
                <option>Azithrocin 500 Tablet</option>
                </optgroup>
            <optgroup label="B">
            <option>Bexidal Tablet</option>
                </optgroup>
            <optgroup label="C">
            <option>Curin Tablet </option>
                </optgroup>
            <option></option>

         </select>  
         </div>
         <div style="margin-top: 50px">
             <uc1:footer runat="server" ID="footer" />
         </div>
         
  </div>
    </form>
</body>
</html>
