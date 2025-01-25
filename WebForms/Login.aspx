<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <h2>Prijava korisnika</h2>
    <div>
        <asp:Label ID="lblUserName" runat="server" Text="Korisničko ime:"></asp:Label><br />
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblPassword" runat="server" Text="Lozinka:"></asp:Label><br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />
        <asp:Button ID="btnLogin" runat="server" Text="Prijavi se" OnClick="btnLogin_Click" /><br /><br />
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>
