<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

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
        <p>
            <asp:TextBox ID="txtFirstName" runat="server" OnTextChanged="txtFirstName_TextChanged" style="z-index: 1; left: 441px; top: 242px; position: absolute; width: 248px;"></asp:TextBox>
        </p>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name" style="z-index: 1; left: 365px; top: 246px; position: absolute"></asp:Label>
        <p>
            <asp:Label ID="lblLastName" runat="server" Text="Last Name" style="z-index: 1; left: 366px; top: 280px; position: absolute"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 441px; top: 279px; position: absolute; width: 248px;" OnTextChanged="txtLastName_TextChanged"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 382px; top: 112px; position: absolute; font-size: x-large; font-weight: 700; font-family: Arial, Helvetica, sans-serif" Text="Enter Fields To Add Customer"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 495px; top: 479px; position: absolute; right: 597px; height: 26px;" Text="OK" OnClick="btnOK_Click" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 435px; top: 424px; position: absolute"></asp:Label>
        </p>
        <asp:Label ID="lblEmail" runat="server" Text="Email " style="z-index: 1; left: 399px; top: 312px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 440px; top: 312px; position: absolute; width: 248px;"></asp:TextBox>
        <asp:Label ID="lblActive" runat="server" style="z-index: 1; left: 396px; top: 378px; position: absolute; height: 19px; width: 39px;" Text="Active"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 437px; top: 376px; position: absolute; height: 21px; margin-bottom: 0px;" />
        <p>
            <asp:Label ID="lblTelephoneNo" runat="server" Text="Telephone No" style="z-index: 1; left: 346px; top: 344px; position: absolute"></asp:Label>
            <asp:TextBox ID="txtTeleNo" runat="server" style="z-index: 1; left: 440px; top: 345px; position: absolute; width: 248px;" OnTextChanged="txtTeleNo_TextChanged"></asp:TextBox>
            <asp:Label runat="server" style="z-index: 0; left: 344px; top: 215px; position: absolute; height: 294px; width: 399px; margin-right: 1px;" BackColor="Silver"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 432px; top: 26px; position: absolute; font-size: xx-large; font-weight: 700; font-family: Arial, Helvetica, sans-serif" Text="DRIP DRIP LTD"></asp:Label>
        </p>
    </form>
</body>
</html>
