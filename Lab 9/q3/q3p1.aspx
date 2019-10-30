<%@ Page Language="C#" AutoEventWireup="true" CodeFile="q3p1.aspx.cs" Inherits="_Default" %>

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
        <asp:DropDownList ID="DropDownList2" DataTextField="CityName" runat="server" DataSourceID="SqlDataSource1">
        </asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName ="System.Data.SqlClient" ConnectionString ="<%$ connectionStrings:city %>" SelectCommand="select CityName from City where StateId = @state">
            <SelectParameters>
                <asp:ControlParameter ControlID ="DropDownList1" Name="state" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
