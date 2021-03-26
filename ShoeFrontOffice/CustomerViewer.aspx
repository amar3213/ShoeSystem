<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerViewer.aspx.cs" Inherits="CustomerViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Customer.css"/> 
    <link href="Customer.css" rel="stylesheet" type="text/css" />
    <title></title>
    <style type="text/css">

    </style>
</head>

<body style="height: 0px">
    <form id="form1" runat="server">
        <header>

            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Bin/Images/chimney-home-icon-transparent-1.png" OnClick="ImageButton1_Click" style="z-index: 1; left: 22px; top: 23px; position: absolute; height: 61px; width: 83px" />

            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 422px; top: 11px; position: absolute; font-size: xx-large; font-weight: 700; font-family: Arial, Helvetica, sans-serif" Text="DRIP DRIP LTD"></asp:Label>

        </header>
        <article>

        </article>
        <div>
        &nbsp;</div>
        <asp:ListBox ID="lstCustomers" runat="server" style="z-index: 1; left: 178px; top: 563px; position: absolute; height: 78px; width: 381px; margin-right: 0px; margin-bottom: 0px; right: 558px;" BackColor="#E5E5E5"></asp:ListBox>
        <asp:Button ID="btnDelete" runat="server" Font-Bold="True" Font-Size="Small" style="z-index: 1; left: 310px; top: 501px; position: absolute; height: 47px; width: 117px; right: 698px;" Text="Delete Customer" OnClick="btnDelete_Click" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnSearch" runat="server" Font-Bold="True" style="z-index: 1; left: 14px; top: 341px; position: absolute; height: 47px; width: 117px" Text="Search Customer" Font-Size="Small" OnClick="btnSearch_Click" />
        <p>
            <asp:Button ID="btnEdit" runat="server" Font-Bold="True" Font-Size="Small" style="z-index: 1; left: 441px; top: 501px; position: absolute; height:  47px; width: 117px" Text="Edit Customer" OnClick="btnEdit_Click" />
            <asp:Button ID="btnAdd" runat="server" Font-Bold="True" Font-Size="Small" OnClick="btnAdd_Click" style="z-index: 1; left: 13px; top: 263px; position: absolute; height: 47px; width: 117px; right: 995px;" Text="Add Customer" />
        </p>
        <asp:TextBox ID="txtEmailBox" runat="server" style="z-index: 1; left: 179px; top: 264px; position: absolute; width: 270px" BackColor="#E5E5E5"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 185px; top: 397px; position: absolute; height: 19px; width: 360px;" ForeColor="Red"></asp:Label>
        <asp:Label ID="lblSearchCustomer" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="False" style="z-index: 1; left: 147px; top: 113px; position: absolute; width: 243px; height: 25px; font-family: Arial, Helvetica, sans-serif;" Text="Search Customer by Email"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 181px; top: 293px; position: absolute; width: 94px; height: 20px; " Text="Apply" OnClick="btnApply_Click" />
        <p>
        <asp:Button ID="btnDisplayAll" runat="server" Font-Bold="True" style="z-index: 1; left: 180px; top: 501px; position: absolute; height: 47px; width: 117px" Text="Display All" Font-Size="Small" OnClick="btnDisplayAll_Click" />
        </p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" style="z-index: 1; left: 183px; top: 238px; position: absolute; width: 141px; font-family: Arial, Helvetica, sans-serif" Text="Enter Email"></asp:Label>
    </form>
</body>
</html>
