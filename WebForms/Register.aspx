<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebForms.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registriraj se</h2>
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br />
    <asp:Label ID="lblUserName" runat="server" Text="Korisničko ime:"></asp:Label>
    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
    <asp:Label ID="lblFullName" runat="server" Text="Puno ime:"></asp:Label>
    <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox><br />
    <asp:Label ID="lblPassword" runat="server" Text="Lozinka:"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
    <asp:Label ID="lblConfirmPassword" runat="server" Text="Ponovljena lozinka:"></asp:Label>
    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox><br />
    <asp:Button ID="btnRegister" runat="server" Text="Registriraj" OnClick="btnRegister_Click" />

</asp:Content>
