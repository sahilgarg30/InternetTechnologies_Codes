<%@ Page Language="C#" AutoEventWireup="true" CodeFile="extra1p1.aspx.cs" Inherits="extra1p1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    
    </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="27px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Validate" />
        </p>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
    </form>
</body>
</html>
