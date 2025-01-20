<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebForms.Register" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Register</h2>
    <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label><br />
    <asp:TextBox ID="txtUsername" runat="server" Placeholder="Username"></asp:TextBox><br />
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Password"></asp:TextBox><br />
    <asp:TextBox ID="txtFullName" runat="server" Placeholder="Full Name"></asp:TextBox><br />
    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
</asp:Content>