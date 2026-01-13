<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormsLab6.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login</h2>

    <p>
        Korisničko ime:
        <asp:TextBox ID="txtUserName" runat="server" />
    </p>
    <p>
        Lozinka:
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
    </p>

    <asp:Button ID="btnLogin" runat="server" Text="Prijava" OnClick="btnLogin_Click" />
    <br /><br />
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />
</asp:Content>
