<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Login</h3>
    <p>Korisnicko ime
        <asp:TextBox ID="tbLoginKorisnickoIme" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </p>
    <p>Lozinka
        <asp:TextBox ID="tbLoginLozinka" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btPrijava" runat="server" OnClick="btPrijava_Click" Text="Prijava" />
    </p>

</asp:Content>
