<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebForms.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registracija</h2>
    Korisničko ime: <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox><br />
    Lozinka: <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox><br />
    Ime: <asp:TextBox ID="tbFullName" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnRegister" runat="server" Text="Registriraj" OnClick="btnRegister_Click" /><br />
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>
