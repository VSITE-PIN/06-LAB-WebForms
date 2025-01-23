<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" MasterPageFile="~/Site.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>Registracija</h2>
    
    
    <asp:Label ID="lblUsername" runat="server" Text="Korisničko ime:" AssociatedControlID="txtUsername" />
    <asp:TextBox ID="txtUsername" runat="server" placeholder="Unesite korisničko ime" />

    <br />
    
    
    <asp:Label ID="lblPassword" runat="server" Text="Lozinka:" AssociatedControlID="txtPassword" />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Unesite lozinku" />
    
    <br />

    <asp:Label ID="lblPasswordRepeated" runat="server" Text="Ponovljena lozinka:" AssociatedControlID="txtPassword" />
    <asp:TextBox ID="txtPasswordRepeated" runat="server" TextMode="Password" placeholder="Unesite ponovljenu lozinku" />

    <br />
    
    <asp:Label ID="lblFullName" runat="server" Text="Ime i prezime:" AssociatedControlID="txtFullName" />
    <asp:TextBox ID="txtFullName" runat="server" placeholder="Unesite ime i prezime" />

    <br />
    
    
    <asp:Button ID="btnRegister" runat="server" Text="Registriraj se" OnClick="btnRegister_Click" />
    
    
    <asp:Label ID="lblError" runat="server" ForeColor="Red" />
</asp:Content>
