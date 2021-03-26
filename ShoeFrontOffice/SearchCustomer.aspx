<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchCustomer.aspx.cs" Inherits="Search_Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 484px; top: 360px; position: absolute"></asp:TextBox>
            </p>
        <p>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 808px; top: 359px; position: absolute"></asp:TextBox>
        </p>
        <p>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 483px; top: 428px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtTeleNo" runat="server" style="z-index: 1; left: 807px; top: 422px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name" style="z-index: 1; left: 408px; top: 360px; position: absolute"></asp:Label>
            <asp:Label ID="lblLastName" runat="server" Text="Last Name" style="z-index: 1; left: 729px; top: 360px; position: absolute"></asp:Label>
            </p>
        <p>
        <asp:Label ID="lblEmail" runat="server" Text="Email " style="z-index: 1; left: 410px; top: 429px; position: absolute"></asp:Label>
            <asp:Label ID="lblTelephoneNo" runat="server" Text="Telephone No" style="z-index: 1; left: 713px; top: 424px; position: absolute"></asp:Label>
            </p>
        <p>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 480px; top: 499px; position: absolute; height: 21px; margin-bottom: 0px;" />
        <asp:Label ID="lblActive" runat="server" style="z-index: 1; left: 433px; top: 502px; position: absolute; height: 19px; width: 39px;" Text="Active"></asp:Label>
        </p>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 466px; top: 274px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 379px; top: 277px; position: absolute" Text="CustomerID"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 609px; top: 570px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 555px; top: 571px; position: absolute; right: 531px;" Text="Find" OnClick="btnFind_Click" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 379px; top: 240px; position: absolute" Text="Enter Customer ID to view detail"></asp:Label>
    </form>
</body>
</html>
