<%@ Page Title="Registracija" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebFormsLab6.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registriraj se</h2>

    <p>
        Korisničko ime:
        <asp:TextBox ID="txtUserName" runat="server" />
    </p>
    <p>
        Puno ime:
        <asp:TextBox ID="txtFullName" runat="server" />
    </p>
    <p>
        Lozinka:
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
    </p>
    <p>
        Ponovljena lozinka:
        <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" />
    </p>

    <asp:Button ID="btnRegister" runat="server" Text="Registriraj" OnClick="btnRegister_Click" />
    <br /><br />
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />
</asp:Content>
