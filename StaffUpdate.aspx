<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffUpdate.aspx.cs" Inherits="ShoeStore.StaffUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Update Staff</h1>
            <div class="textRed">Validation not implemented!</div>
            <br /><br />
            <div class="label">Name:</div><div>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox> Required. String up to 50 chars</div>
            <br /><br />
            <div class="label">Surname:</div><div><asp:TextBox ID="txtSurname" runat="server"></asp:TextBox> Required. String up to 50 chars</div>
            <br /><br />
            <div class="label">Birth Date:</div><div><asp:TextBox ID="txtBirthDate" runat="server"></asp:TextBox> Required. Date as 31/12/2021</div>
            <br /><br />
            <div class="label">Employed Date:</div><div>
                <asp:TextBox ID="txtEmployedDate" runat="server"></asp:TextBox> Required. Date as 31/12/2021</div>
            <br /><br />
            <div class="label">Phone Number:</div><div><asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox> Required. String up to 20 chars</div>
            <br /><br />
            <div class="label">Salary:</div><div><asp:TextBox ID="txtSalary" runat="server"></asp:TextBox> Required. Decimal</div>
            <br /><br /><br /><br />
             <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /> <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />  
            <br /><br />
            <asp:Label ID="lblSuccess" runat="server" Text="" CssClass="textRed" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
