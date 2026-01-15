<%@ Page Title="Login"
    Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Login.aspx.cs"
    Inherits="WebForms.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Login</h2>

    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
    <br /><br />

    <table>
        <tr>
            <td>Korisničko ime:</td>
            <td><asp:TextBox ID="txtUserName" runat="server" /></td>
        </tr>
        <tr>
            <td>Lozinka:</td>
            <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnLogin"
                            runat="server"
                            Text="Prijava"
                            OnClick="btnLogin_Click" />
            </td>
        </tr>
    </table>

</asp:Content>