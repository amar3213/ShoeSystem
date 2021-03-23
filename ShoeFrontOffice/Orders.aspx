<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Orders.aspx.cs" Inherits="Orders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 71px;
        }
        .auto-style2 {
            margin-left: 53px;
        }
        .auto-style3 {
            margin-left: 55px;
        }
        .auto-style4 {
            margin-left: 40px;
        }
        .auto-style5 {
            margin-left: 13px;
        }
        .auto-style6 {
            margin-left: 21px;
        }
        .auto-style7 {
            margin-left: 107px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lbloderID" runat="server" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" CssClass="auto-style1" Width="156px"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Order Date"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Order Item"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style3"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style4" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Customer Name"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style5"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Order Address"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style6"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="Active" runat="server" />
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="lblError"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Okay" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" CssClass="auto-style7" Text="Cancel" />
        </p>
    </form>
</body>
</html>
