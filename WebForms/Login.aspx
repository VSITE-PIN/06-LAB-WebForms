<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

    <h3>Login</h3>
    <p>
        Korisničko ime:
        <asp:TextBox ID="txtImeLogin" runat="server"></asp:TextBox>
    </p>
    <p>
        Lozinka:
        <asp:TextBox ID="txtLozinkaLogin" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnPrijavaLogin" runat="server" OnClick="btnPrijavaLogin_Click" Text="Prijava" />
    </p>
    

</asp:Content>