<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCustomer.aspx.cs" Inherits="DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Customer.css"/> 
    <link href="Customer.css" rel="stylesheet" type="text/css" />
    <title></title>
    <style type="text/css">

    </style>
</head>
<body>
    <header></header>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblConfirmation" runat="server" style="z-index: 1; width: 323px; left: 387px; top: 290px; position: absolute; font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: small;" Text="Are you sure you want to delete this Customer?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; width: 69px; left: 451px; top: 348px; position: absolute; height: 26px;" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" height="26px" OnClick="btnNo_Click" style="z-index: 1; left: 574px; top: 348px; position: absolute; width: 70px;" Text="No" />
        <asp:Label ID="Label1" runat="server" BackColor="Silver" style="z-index: 0; left: 372px; top: 256px; position: absolute; height: 132px; width: 342px"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 432px; top: 26px; position: absolute; font-size: xx-large; font-weight: 700; font-family: Arial, Helvetica, sans-serif" Text="DRIP DRIP LTD"></asp:Label>
        </p>
    </form>
</body>
</html>
