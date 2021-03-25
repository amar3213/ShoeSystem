<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="ShoeStore.Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Staff</h1><div class="label"><asp:Label ID="LabelRecPerTotal" runat="server" Text="Label"></asp:Label></div>
            <br /><br />
            <div class="label">Id:</div><div><asp:Label ID="LabelId" runat="server" Text="Label"></asp:Label></div>
            <br /><br />
            <div class="label">Name:</div><div><asp:Label ID="LabelName" runat="server" Text="Label"></asp:Label></div>
            <br /><br />
            <div class="label">Surname:</div><div><asp:Label ID="LabelSurname" runat="server" Text="Label"></asp:Label></div>
            <br /><br />
            <div class="label">Birth Date:</div><div><asp:Label ID="LabelBirthDate" runat="server" Text="Label"></asp:Label></div>
            <br /><br />
            <div class="label">Employed Date:</div><div><asp:Label ID="LabelEmployedDate" runat="server" Text="Label"></asp:Label></div>
            <br /><br />
            <div class="label">Phone Number:</div><div><asp:Label ID="LabelPhoneNumber" runat="server" Text="Label"></asp:Label></div>
            <br /><br />
            <div class="label">Salary:</div><div><asp:Label ID="LabelSalary" runat="server" Text="Label"></asp:Label></div>
            <br /><br /><br /><br />
            <asp:Button ID="btnPrevious" runat="server" Text="Previous" OnClick="btnPrevious_Click" />  <asp:Button ID="btnNext" runat="server" Text="Next" OnClick="btnNext_Click" />  <asp:Button ID="btnNew" runat="server" Text="New" OnClick="btnNew_Click" />  <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />  <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </div>
    </form>
</body>
</html>
