<%@ Page Language="C#" AutoEventWireup="true" CodeFile="q4page1.aspx.cs" Inherits="q4page1" %>

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
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
            &nbsp; &nbsp; &nbsp; &nbsp; 
            <asp:Label ID="Label1" runat="server" Text="You have 3 tries left."></asp:Label>
        </p>
    </form>
</body>
</html>
