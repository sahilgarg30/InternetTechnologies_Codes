<%@ Page Language="C#" AutoEventWireup="true" CodeFile="e1p1.aspx.cs" Inherits="e1p1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="email ID required." ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="password required." ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
