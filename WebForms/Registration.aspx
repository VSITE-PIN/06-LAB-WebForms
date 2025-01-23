<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebForms.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registriraj se</h2>
    <p>
        &nbsp;</p>
    <p>
        Korisničko ime:
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
    </p>
    <p>
        Puno ime:
        <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
    </p>
    <p>
        Lozinka:
        <asp:TextBox ID="password1" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        Ponovljena lozinka:
        <asp:TextBox ID="password2" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Registriraj" />
    </p>
    <p>
        <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
    </p>
</asp:Content>
