﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="q2p2.aspx.cs" Inherits="q2p2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1"></asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName ="System.Data.SqlClient" ConnectionString="<%$ connectionStrings:city %>" 
            SelectCommand ="select * from Trip where Name = @name">
        <SelectParameters>
            <asp:QueryStringParameter Name ="name" QueryStringField="Name" />
        </SelectParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
