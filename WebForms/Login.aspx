<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login</h2>
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
    <div>
        
        <asp:Label ID="lblUserName" runat="server" Text="Korisničko ime: " AssociatedControlID="txtUserName"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" Placeholder="Korisničko ime"></asp:TextBox>
        <br />

        
        <asp:Label ID="lblPassword" runat="server" Text="Lozinka: " AssociatedControlID="txtPassword"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Lozinka"></asp:TextBox>
        <br />

       
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    </div>
</asp:Content>