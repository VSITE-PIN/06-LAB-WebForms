
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BazaConnected.aspx.cs" Inherits="WebForms.Baza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<div>
ID:<asp:TextBox ID="tbId" runat="server"></asp:TextBox>
UserName:<asp:TextBox ID="UserName" runat="server"></asp:TextBox>
Password:<asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
FullName:<asp:TextBox ID="tbFullName" runat="server"></asp:TextBox>
<hr />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
<hr />
<asp:Button ID="btnInsert" runat="server" Text="Registriraj" OnClick="btnInsert_Click" />
<asp:Label ID="lblTotal" runat="server"></asp:Label>
</div>

</asp:Content>
