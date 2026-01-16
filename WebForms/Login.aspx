<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login</h2>

    <asp:Label ID="lblMsg" runat="server" CssClass="text-danger"></asp:Label>
    <br /><br />

    <div class="mb-3">
        <asp:Label runat="server" AssociatedControlID="tbUserName" Text="Korisničko ime"></asp:Label>
        <asp:TextBox ID="tbUserName" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="mb-3">
        <asp:Label runat="server" AssociatedControlID="tbPassword" Text="Lozinka"></asp:Label>
        <asp:TextBox ID="tbPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
    </div>

    <asp:Button ID="btnLogin" runat="server" Text="Prijava" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
</asp:Content>
