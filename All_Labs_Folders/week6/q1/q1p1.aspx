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
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        </asp:RadioButtonList>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Submit" />
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="no student" ControlToValidate ="DropDownList1"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="no house" ControlToValidate ="RadioButtonList1"></asp:RequiredFieldValidator>
        </p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="no class" ControlToValidate ="TextBox1"></asp:RequiredFieldValidator>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="no email" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
        </p>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="class out of range" ControlToValidate="TextBox1" MaximumValue="12" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        <p>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="wrong email" ControlToValidate="TextBox2" ValidationExpression=".+@.+"></asp:RegularExpressionValidator>
        </p>
        
        <asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="true" runat="server" />
        <p>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="wrong phone number" ControlToValidate ="TextBox3" EnableClientScript="false" OnServerValidate="CustomValidator1_ServerValidate1"></asp:CustomValidator>
        </p>
    </form>
</body>
</html>
