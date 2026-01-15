<%@ Page Title="Registracija" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Registracija.aspx.cs" Inherits="WebForms.Registracija" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registracija</h2>

    <asp:Label runat="server" Text="Korisničko ime:" AssociatedControlID="txtUserName" />
    <asp:TextBox ID="txtUserName" runat="server" />
    <br /><br />

    <asp:Label runat="server" Text="Puno ime:" AssociatedControlID="txtFullName" />
    <asp:TextBox ID="txtFullName" runat="server" />
    <br /><br />

    <asp:Label runat="server" Text="Lozinka:" AssociatedControlID="txtPassword" />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
    <br /><br />

    <asp:Label runat="server" Text="Ponovi lozinku:" AssociatedControlID="txtPassword2" />
    <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" />
    <br /><br />

    <asp:Button ID="btnRegister" runat="server" Text="Registriraj" OnClick="btnRegister_Click" />
    <br /><br />

    <asp:Label ID="lblMsg" runat="server" />
</asp:Content>
