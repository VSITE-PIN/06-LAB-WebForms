<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebForms.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Registriraj se</h3>
    Korisničko ime
    <asp:TextBox ID="tbIme" runat="server"></asp:TextBox>

    <br />
    Puno ime
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    Lozinka
    <asp:TextBox ID="tbLozinka" runat="server"></asp:TextBox>
    <br />
    Ponovljena lozinka
    <asp:TextBox ID="tbPonovljenaLozinka" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btRegistriraj" runat="server" Text="Registriraj" OnClick="btRegistriraj_Click" />


</asp:Content>
