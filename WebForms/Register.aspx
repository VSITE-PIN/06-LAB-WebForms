<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebForms.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Register</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registriraj se</h2>

    <!-- Form for registration -->
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Visible="false"></asp:Label>
    
    <asp:TextBox ID="txtUsername" runat="server" Placeholder="Korisničko ime" MaxLength="50"></asp:TextBox><br />
    <asp:TextBox ID="txtFullName" runat="server" Placeholder="Puno ime" MaxLength="100"></asp:TextBox><br />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Lozinka" MaxLength="50"></asp:TextBox><br />
    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" Placeholder="Ponovljena lozinka" MaxLength="50"></asp:TextBox><br />
    
    <asp:Button ID="btnRegister" runat="server" Text="Registriraj" OnClick="btnRegister_Click" />
</asp:Content>
