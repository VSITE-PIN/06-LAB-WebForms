<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Login</h1>
    <br />
    <br />
    <br />
    Korisnicko ime: <asp:TextBox ID="KorisnickoIme" runat="server"></asp:TextBox>
    <br />
    <br />
    Lozinka: <asp:TextBox ID="Lozinka" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Prijava" runat="server" Text="Prijava" OnClick="Prijava_Click" />
</asp:Content>