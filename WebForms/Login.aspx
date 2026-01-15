<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login</h2>

    <asp:Label runat="server" Text="Korisničko ime:" AssociatedControlID="txtUserName" />
    <asp:TextBox ID="txtUserName" runat="server" />
    <br /><br />

    <asp:Label runat="server" Text="Lozinka:" AssociatedControlID="txtPassword" />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
    <br /><br />

    <asp:Button ID="btnLogin" runat="server" Text="Prijava" OnClick="btnLogin_Click" />
    <br /><br />

    <asp:Label ID="lblMsg" runat="server" />
</asp:Content>