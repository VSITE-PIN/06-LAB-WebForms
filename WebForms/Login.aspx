<%@ Page Title="Prijava" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Prijava korisnika</h2>
    <asp:TextBox ID="txtUserName" runat="server" Placeholder="Korisničko ime"></asp:TextBox><br />
    <asp:TextBox ID="txtPassword" runat="server" Placeholder="Lozinka" TextMode="Password"></asp:TextBox><br />
    <asp:Button ID="btnLogin" runat="server" Text="Prijava" OnClick="btnLogin_Click" /><br />
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>
