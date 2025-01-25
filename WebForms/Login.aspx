<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div> 
        <h2>Login</h2>
        Korisničko ime: 
        <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox> <br /> <br />
        
        Lozinka: 
        <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox> <br /> <br />
        
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" Height="22px" Width="115px" /> <br /> <br />
        
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>
