<%@ Page Language="C#" AutoEventWireup="true" CodeFile="q3.aspx.cs" Inherits="q3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 120px;
        }
        .auto-style3 {
            position: relative;
            left: 27px;
            top: 29px;
        }
        .auto-style4 {
            position: relative;
            left: -96px;
            top: -44px;
            height: 26px;
        }
        .auto-style5 {
            position: relative;
            margin-bottom: 0px;
        }
        .auto-style6 {
            position: relative;
            left: 105px;
            top: -99px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style5"></asp:TextBox>
    
    </div>
    
        <asp:ListBox ID="ListBox1" runat="server" CssClass="auto-style3" Height="381px" Width="267px"></asp:ListBox>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style6" Height="98px" Width="229px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style4" OnClick="Button1_Click" Text="Continue shopping" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
