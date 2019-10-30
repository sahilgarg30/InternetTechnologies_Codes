<%@ Page Language="C#" AutoEventWireup="true" CodeFile="q2p1.aspx.cs" Inherits="q2p1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="ListBox1" runat="server" DataTextField ="Name" DataSourceID="SqlDataSource1"></asp:ListBox>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName ="System.Data.SqlClient" ConnectionString="<%$ connectionStrings:city %>" 
            SelectCommand ="select distinct Name from Trip">
        </asp:SqlDataSource>
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
