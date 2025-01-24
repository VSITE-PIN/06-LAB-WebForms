<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login</h2>
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br />
    <asp:Label ID="lblUserName" runat="server" Text="Korisničko ime:"></asp:Label>
    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
    
    <asp:Label ID="lblPassword" runat="server" Text="Lozinka:"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
    
    <asp:Button ID="btnLogin" runat="server" Text="Prijava" OnClick="btnLogin_Click" />
</asp:Content>
