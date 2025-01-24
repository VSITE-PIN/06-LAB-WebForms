﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="WebForms.Registracija" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>Registriraj se</h2>

    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br />

    Korisničko ime:<br />
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br /><br />

    Puno ime:<br />
    <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox><br /><br />

    Lozinka:<br />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />

    Ponovljena lozinka:<br />
    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />

    <asp:Button ID="btnRegister" runat="server" Text="Registriraj" OnClick="btnRegister_Click" />
</asp:Content>