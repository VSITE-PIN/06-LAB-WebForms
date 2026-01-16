<%@ Page Title="Registracija" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="WebForms.Registracija" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registracija</h2>

    <asp:Label ID="lblMsg" runat="server" CssClass="text-danger"></asp:Label>
    <br /><br />

    <div class="mb-3">
        <asp:Label runat="server" AssociatedControlID="tbUserName" Text="Korisničko ime"></asp:Label>
        <asp:TextBox ID="tbUserName" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="mb-3">
        <asp:Label runat="server" AssociatedControlID="tbFullName" Text="Ime i prezime"></asp:Label>
        <asp:TextBox ID="tbFullName" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="mb-3">
        <asp:Label runat="server" AssociatedControlID="tbPassword" Text="Lozinka"></asp:Label>
        <asp:TextBox ID="tbPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="mb-3">
        <asp:Label runat="server" AssociatedControlID="tbPassword2" Text="Ponovi lozinku"></asp:Label>
        <asp:TextBox ID="tbPassword2" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
    </div>

    <asp:Button ID="btnRegister" runat="server" Text="Registriraj se" CssClass="btn btn-primary" OnClick="btnRegister_Click" />
</asp:Content>
