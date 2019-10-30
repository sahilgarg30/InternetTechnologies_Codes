<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" MinimumValue ="1000" MaximumValue ="9999" Type ="Integer" runat="server" ControlToValidate ="TextBox2" ErrorMessage="Wrong phone"></asp:RangeValidator>
    </p>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />

</asp:Content>

