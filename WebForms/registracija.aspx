<%@ Page Title="Registracija" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="YourNamespace.Registracija" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registriraj se</h2>
    <table>
        <tr>
            <td>Korisničko ime:</td>
            <td><asp:TextBox ID="txtKorisnickoIme" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Puno ime:</td>
            <td><asp:TextBox ID="txtPunoIme" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Lozinka:</td>
            <td><asp:TextBox ID="txtLozinka" TextMode="Password" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Ponovljena lozinka:</td>
            <td><asp:TextBox ID="txtPonovljenaLozinka" TextMode="Password" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnRegistriraj" runat="server" Text="Registriraj" OnClick="btnRegistriraj_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
