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
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:TextBox ID="txtFirstName" runat="server" OnTextChanged="txtFirstName_TextChanged" style="z-index: 1; left: 484px; top: 360px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name" style="z-index: 1; left: 408px; top: 360px; position: absolute"></asp:Label>
        <p>
            <asp:Label ID="lblLastName" runat="server" Text="Last Name" style="z-index: 1; left: 729px; top: 360px; position: absolute"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 808px; top: 359px; position: absolute" OnTextChanged="txtLastName_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 600px; top: 531px; position: absolute; right: 518px; height: 26px;" Text="OK" OnClick="btnOK_Click" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 415px; top: 588px; position: absolute"></asp:Label>
        </p>
        <asp:Label ID="lblEmail" runat="server" Text="Email " style="z-index: 1; left: 410px; top: 429px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 483px; top: 428px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblActive" runat="server" style="z-index: 1; left: 433px; top: 502px; position: absolute; height: 19px; width: 39px;" Text="Active"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 480px; top: 499px; position: absolute; height: 21px; margin-bottom: 0px;" />
        <p>
            <asp:Label ID="lblTelephoneNo" runat="server" Text="Telephone No" style="z-index: 1; left: 713px; top: 424px; position: absolute"></asp:Label>
            <asp:TextBox ID="txtTeleNo" runat="server" style="z-index: 1; left: 807px; top: 422px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 686px; top: 532px; position: absolute; height: 23px;" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
