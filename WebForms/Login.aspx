<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormsLab.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <h2>Login</h2>
  Korisničko ime: <asp:TextBox ID="tbLoginUser" runat="server"></asp:TextBox><br />
  Lozinka: <asp:TextBox ID="tbLoginPass" runat="server" TextMode="Password"></asp:TextBox><br />
  <asp:Button ID="btnLogin" runat="server" Text="Ulogiraj se" OnClick="btnLogin_Click" /><br />
  <asp:Label ID="lblLoginMsg" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>
