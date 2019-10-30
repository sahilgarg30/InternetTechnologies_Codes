<%@ Page Language="C#" AutoEventWireup="true" CodeFile="q4p1.aspx.cs" Inherits="q4p1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true">
        </asp:DropDownList>
        <asp:ListBox ID="ListBox1" runat="server" DataSourceID ="SqlDataSource1" DataTextField="name" AutoPostBack="true"></asp:ListBox>
        <asp:GridView ID="GridView1" runat="server" DataSourceID ="SqlDataSource2">
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient" ConnectionString ="<%$ connectionStrings:actors %>" 
            SelectCommand="select name from Actors where category = @cat">
        <SelectParameters>
            <asp:ControlParameter Name ="cat" ControlID ="DropDownList1" PropertyName="SelectedValue" />
        </SelectParameters>
        </asp:SqlDataSource>

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ProviderName="System.Data.SqlClient" ConnectionString ="<%$ connectionStrings:actors %>"
            SelectCommand="select * from Actors where name = @nam">
            <SelectParameters>
            <asp:ControlParameter Name ="nam" ControlID ="ListBox1" PropertyName="SelectedValue" />
        </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
