<%@ Page Language="C#" AutoEventWireup="true" CodeFile="q1p1.aspx.cs" Inherits="q1p1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButtonList ID="rb1" runat="server"></asp:RadioButtonList>
        <asp:CheckBoxList ID="cb1" runat="server"></asp:CheckBoxList>
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
