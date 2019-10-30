<%@ Page Language="C#" AutoEventWireup="true" CodeFile="q2p1.aspx.cs" Inherits="q2p1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     Choose Genre: <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Drop_Change"></asp:DropDownList><br /><br />
     Actors<br /><asp:ListBox ID="ListBox1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="List_Change"></asp:ListBox><br /><br />
 
        <b>Name: </b> <asp:Label ID="Name" runat="server" Text=""></asp:Label><br />
        <b>Age:  </b> <asp:Label ID="Age" runat="server" Text=""></asp:Label><br />
 
    </div>
    </form>
</body>
</html>
