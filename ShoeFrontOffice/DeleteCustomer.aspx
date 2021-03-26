<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCustomer.aspx.cs" Inherits="DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:grey;">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblConfirmation" runat="server" style="z-index: 1; width: 323px; left: 286px; top: 135px; position: absolute;" Text="Are you sure you want to delete this Customer?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; width: 59px; left: 341px; top: 180px; position: absolute; height: 26px;" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" height="26px" OnClick="btnNo_Click" style="z-index: 1; left: 446px; top: 182px; position: absolute;" Text="No" width="59px" />
    </form>
</body>
</html>
