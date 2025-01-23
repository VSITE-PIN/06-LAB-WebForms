<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <h2>Login</h2>
        <table>
            <tr>
                <td>Korisničko ime:</td>
                <td><asp:TextBox ID="txtKorisnickoIme" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Lozinka:</td>
                <td><asp:TextBox ID="txtLozinka" TextMode="Password" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                <asp:Button ID="btnPrijava" runat="server" Text="Prijava" OnClick="btnPrijava_Click" />
            </td>
            </tr>
        </table>
</asp:Content>