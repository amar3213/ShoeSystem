<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

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
    <form id="form1" runat="server">
    <header>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 432px; top: 17px; position: absolute; font-size: xx-large; font-weight: 700; font-family: Arial, Helvetica, sans-serif" Text="DRIP DRIP LTD"></asp:Label>
        </header>
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 515px; top: 194px; position: absolute; text-transform: uppercase; text-decoration: underline; font-size: large; font-weight: 700; font-family: Arial, Helvetica, sans-serif" Text="Welcome "></asp:Label>
        <asp:Button ID="btnOrder" runat="server" style="z-index: 1; left: 570px; top: 325px; position: absolute; height: 40px; width: 181px;" Text="Order Management" OnClick="btnOrder_Click" />
        <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; left: 342px; top: 324px; position: absolute; height: 40px; width: 180px;" Text="Customer Management" OnClick="btnCustomer_Click" />
        <p>
            <asp:Button ID="btnStaff" runat="server" style="z-index: 1; left: 570px; top: 388px; position: absolute; height: 41px; width: 179px;" Text="Staff Management" />
        </p>
        <asp:Label ID="Label3" runat="server" style="z-index: 0; left: 323px; top: 272px; position: absolute; height: 194px; width: 444px" BackColor="#CCCCCC">Select One</asp:Label>
        <p>
            <asp:Button ID="btnStock0" runat="server" style="z-index: 1; left: 343px; top: 390px; position: absolute; height: 40px; width: 179px;" Text="Stock Management" />
        </p>
    </form>
</body>
</html>
