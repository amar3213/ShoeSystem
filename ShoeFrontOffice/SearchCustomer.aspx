<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchCustomer.aspx.cs" Inherits="Search_Customer" %>

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
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 357px; top: 307px; position: absolute"></asp:TextBox>
            </p>
        <p>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 651px; top: 305px; position: absolute"></asp:TextBox>
        </p>
        <p>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 355px; top: 351px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtTeleNo" runat="server" style="z-index: 1; left: 651px; top: 351px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblLastName" runat="server" Text="Last Name" style="z-index: 1; left: 577px; top: 306px; position: absolute"></asp:Label>
            </p>
        <p>
        <asp:Label ID="lblEmail" runat="server" Text="Email " style="z-index: 1; left: 309px; top: 351px; position: absolute; width: 33px;"></asp:Label>
            <asp:Label ID="lblTelephoneNo" runat="server" Text="Telephone No" style="z-index: 1; left: 561px; top: 354px; position: absolute"></asp:Label>
            </p>
        <p>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 325px; top: 407px; position: absolute; height: 21px; margin-bottom: 0px;" />
        <asp:Label ID="lblActive" runat="server" style="z-index: 1; left: 283px; top: 410px; position: absolute; height: 19px; width: 39px;" Text="Active"></asp:Label>
            <asp:Label ID="Label4" runat="server" BackColor="Silver" style="z-index: 0; left: 272px; top: 284px; position: absolute; height: 210px; width: 538px; margin-bottom: 0px;"></asp:Label>
        </p>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 480px; top: 167px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 400px; top: 169px; position: absolute" Text="CustomerID"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 489px; top: 456px; position: absolute; height: 24px; width: 101px;" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 649px; top: 164px; position: absolute; right: 437px; height: 24px; bottom: 469px;" Text="Find" OnClick="btnFind_Click" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 357px; top: 119px; position: absolute; font-size: x-large; font-weight: 700; font-family: Arial, Helvetica, sans-serif;" Text="Enter Customer ID to view detail"></asp:Label>
        <p>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name" style="z-index: 1; left: 278px; top: 308px; position: absolute"></asp:Label>
            </p>
        <asp:Label ID="Label3" runat="server" Font-Strikeout="True" style="z-index: 1; left: 10px; top: 300px; position: absolute" Text="                                                                "></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 432px; top: 26px; position: absolute; font-size: xx-large; font-weight: 700; font-family: Arial, Helvetica, sans-serif" Text="DRIP DRIP LTD"></asp:Label>
        </p>
    </form>
</body>
</html>
