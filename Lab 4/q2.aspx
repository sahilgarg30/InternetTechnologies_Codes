<%@ Page Language="C#" AutoEventWireup="true" CodeFile="q2.aspx.cs" Inherits="q2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form runat="server">
<div>
Select Employee ID :
<asp:DropDownList ID="employeeId" runat="server" Width="194px"
Height="22px"/><br /><br />
Specify employee name:<br />
<asp:TextBox ID="name" runat="server" /><br /><br />
Enter date of joining (DD/MM/YYYY):<br />
<asp:TextBox ID="doj" runat="server" Width="240px" Height="85px"/><br /><br />
<asp:Button ID="cmdUpdate" OnClick="cmdUpdate_Click"
runat="server" Width="289px" Height="24px" Text="Am I Eligible for Promotion" />
</div>
<br />&nbsp;
<asp:Image ID="imgDefault" runat="server" Width="212px"
Height="160px" />
<asp:Label ID="eligible" runat="server" Width="256px"
Height="150px" text ="Eligibility"/><br /><br /><br />
</form>
</body>
</html>