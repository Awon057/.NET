<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Two.aspx.cs" Inherits="pages_Two" %>


<%@ Register Src="~/controls/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/controls/footer.ascx" TagPrefix="uc1" TagName="footer" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order</title>
    <link href="../Styles/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <script type="text/javascript">
            var money = 0;

            function faltu(due, labels, takas) {
                var cb = document.getElementById(due);

                var lbl = document.getElementById(labels);

                if (cb.checked) {
                    money = money + parseInt(takas);
                    lbl.textContent = "You have Selected " + money +" taka";
                }
                else {
                    money = money - parseInt(takas);
                    lbl.textContent = "You have Selected " + money + " taka";
                }

                if (money == 0) {
                    lbl.textContent = "";
                }

            }
        </script>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="main">
    <div>
        <uc1:Header runat="server" ID="Header" />
    </div>
        <div style="height: 30px; width: 133px; margin-left: 736px; margin-top: 20px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" Width="100px" />
        </div>
        <div style="height:30px">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                     <asp:Label ID="selected_info" runat="server" Text=""></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div style="height: 310px;width:650px; margin-top: 15px; margin-left: 120px; margin-right: 120px;overflow:auto;border:solid 2px red;">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
             <asp:Panel ID="Panel1" runat="server" Height="280px" style="overflow:auto" Width="648px">
                
            </asp:Panel>
            </ContentTemplate>
            </asp:UpdatePanel>

            <asp:Label ID="mess" runat="server" Text=""></asp:Label>
                <asp:Label ID="label" runat="server" Text=""></asp:Label>
            <asp:Button ID="paid" runat="server" Text="Buy" OnClick="paid_Click" Width="113px" style="margin-left: 299px"/>
 
                

        </div>
        <div>
            <uc1:footer runat="server" ID="footer" />
        </div>
    </div>
    </form>
</body>
</html>
