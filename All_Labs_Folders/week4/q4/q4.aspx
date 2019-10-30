<%@ Page Language="C#" AutoEventWireup="true" CodeFile="q4.aspx.cs" Inherits="q4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Image ID="Image1" runat="server" Height="107px" ImageUrl="captcha.jpg" Width="442px" />
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Width="434px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="219px" />
        &nbsp &nbsp &nbsp  &nbsp <asp:Label ID="Label1" runat="server" Text="Label" Height="20px" Width="200px"></asp:Label>
    </form>
</body>
</html>
