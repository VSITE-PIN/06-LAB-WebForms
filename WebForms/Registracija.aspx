<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="WebForms.Registracija" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Registriraj Se</h1>
    <br />
    <br />
    <br />
    Korisnicko ime: <asp:TextBox ID="KorisnickoIme" runat="server"></asp:TextBox>
    <br />
    <br />
    Puno ime: <asp:TextBox ID="PunoIme" runat="server"></asp:TextBox>
    <br />
    <br />
    Lozinka: <asp:TextBox ID="Lozinka" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    Ponovljena Lozinka: <asp:TextBox ID="PonovljenaLozinka" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Registracija_" runat="server" Text="Registracija" OnClick="Registracija__Click" />
</asp:Content>