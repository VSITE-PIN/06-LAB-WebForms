<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebForms.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Register</h2>
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
    <div>
        
        <asp:Label ID="lblUserName" runat="server" Text="Korisničko ime: " AssociatedControlID="txtUserName"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" Placeholder="Korisničko ime"></asp:TextBox>
        <br />

        
        <asp:Label ID="lblPassword" runat="server" Text="Lozinka: " AssociatedControlID="txtPassword"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Lozinka"></asp:TextBox>
        <br />

        
        <asp:Label ID="lblFullName" runat="server" Text="Puno ime: " AssociatedControlID="txtFullName"></asp:Label>
        <asp:TextBox ID="txtFullName" runat="server" Placeholder="Puno ime"></asp:TextBox>
        <br />

        
        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
    </div>
</asp:Content>
