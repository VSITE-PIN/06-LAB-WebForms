﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>Login</h2>

    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br />

    Korisničko ime:<br />
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br /><br />

    Lozinka:<br />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />

    <asp:Button ID="btnLogin" runat="server" Text="Prijava" OnClick="btnLogin_Click" />
</asp:Content>