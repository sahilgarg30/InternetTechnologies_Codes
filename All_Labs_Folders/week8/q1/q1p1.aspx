<%@ Page Language="C#" AutoEventWireup="true" CodeFile="q1p1.aspx.cs" Inherits="q1p1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update City" />
        </p>
    </form>
</body>
</html>
