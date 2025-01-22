<%@ Page Title="Registracija" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebForms.Registration" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registracija korisnika</h2>
    <asp:TextBox ID="txtUserName" runat="server" Placeholder="Korisničko ime"></asp:TextBox><br />
    <asp:TextBox ID="txtPassword" runat="server" Placeholder="Lozinka" TextMode="Password"></asp:TextBox><br />
    <asp:TextBox ID="txtFullName" runat="server" Placeholder="Puno ime"></asp:TextBox><br />
    <asp:Button ID="btnRegister" runat="server" Text="Registracija" OnClick="btnRegister_Click" /><br />
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>
