<%@ Page Language="C#" AutoEventWireup="true" CodeFile="page1.aspx.cs" Inherits="page1" %>

<!DOCTYPE html>

<html>
<head runat="server">
<title>Magazine Cover</title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 14px;
            left: 320px;
            height: 376px;
        }
    </style>
</head>
<body>
<form runat="server">
<div>
<!-- Here are the controls: -->
Choose a background color:<br />
<asp:DropDownList ID="lstBackColor" runat="server" Width="194px"
Height="22px"/><br /><br />
Choose a font:<br />
<asp:DropDownList ID="lstFontName" runat="server" Width="194px"
Height="22px" /><br /><br />
Specify a numeric font size:<br />
<asp:TextBox ID="txtFontSize" runat="server" /><br /><br />
<asp:CheckBox ID="chkPicture" runat="server"
Text="Add the Default Picture"></asp:CheckBox><br /><br />
Enter the greeting text below:<br />
<asp:TextBox ID="txtGreeting" runat="server" Width="240px" Height="85px"
TextMode="MultiLine" style="position: relative" /><br /><br />
<asp:Button ID="cmdUpdate" OnClick="cmdUpdate_Click"
runat="server" Width="71px" Height="24px" Text="Update" />
</div>
<!-- Here is the card: -->
<asp:Panel ID="pnlCard" runat="server"
Width="339px" HorizontalAlign="Center" CssClass="auto-style1">
<br />&nbsp;
<asp:Label ID="lblGreeting" runat="server" Width="256px"
Height="108px" /><br />
    <br />
    <br />
    <asp:Image ID="imgDefault" runat="server" Height="160px" Width="212px" />
</asp:Panel>
</form>
</body>
</html>