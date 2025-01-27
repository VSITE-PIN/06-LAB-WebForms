<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebForms.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registracija korisnika</h2>
    <div>
        <asp:Label ID="lblUserName" runat="server" Text="Korisničko ime:"></asp:Label><br />
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblPassword" runat="server" Text="Lozinka:"></asp:Label><br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />
        <asp:Label ID="lblFullName" runat="server" Text="Puno ime:"></asp:Label><br />
        <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="btnRegister" runat="server" Text="Registriraj se" OnClick="btnRegister_Click" /><br /><br />
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>