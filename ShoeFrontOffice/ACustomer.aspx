<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

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
            <asp:TextBox ID="txtFirstName" runat="server" OnTextChanged="txtFirstName_TextChanged" style="z-index: 1; left: 127px; top: 92px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 24px; top: 57px; position: absolute" Text="CustomerID"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 127px; top: 53px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 287px; top: 51px; position: absolute" Text="Find" />
        </p>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name" style="z-index: 1; left: 22px; top: 92px; position: absolute"></asp:Label>
        <p>
            <asp:Label ID="lblLastName" runat="server" Text="Last Name" style="z-index: 1; left: 22px; top: 133px; position: absolute"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 126px; top: 130px; position: absolute" OnTextChanged="txtLastName_TextChanged"></asp:TextBox>
        </p>
        <asp:Label ID="lblEmail" runat="server" Text="Email " style="z-index: 1; left: 23px; top: 173px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 123px; top: 168px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblTelephoneNo" runat="server" Text="Telephone No" style="z-index: 1; left: 20px; top: 207px; position: absolute"></asp:Label>
            <asp:TextBox ID="txtTeleNo" runat="server" style="z-index: 1; left: 122px; top: 205px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblActive" runat="server" style="z-index: 1; left: 13px; top: 244px; position: absolute; height: 19px" Text="Active"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 61px; top: 242px; position: absolute; height: 21px;" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 10px; top: 281px; position: absolute; right: 1202px" Text="OK" OnClick="btnOK_Click" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 96px; top: 282px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
