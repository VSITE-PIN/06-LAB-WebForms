<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebForms.Register"  MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Registriraj se</h2>

    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
    <br /><br />

    <table>
        <tr>
            <td>Korisničko ime:</td>
            <td><asp:TextBox ID="txtUserName" runat="server" /></td>
        </tr>
        <tr>
            <td>Puno ime:</td>
            <td><asp:TextBox ID="txtFullName" runat="server" /></td>
        </tr>
        <tr>
            <td>Lozinka:</td>
            <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /></td>
        </tr>
        <tr>
            <td>Ponovljena lozinka:</td>
            <td><asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" /></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnRegister"
                            runat="server"
                            Text="Registriraj"
                            OnClick="btnRegister_Click" />
            </td>
        </tr>
    </table>

</asp:Content>