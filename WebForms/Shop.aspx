<%@ Page Title="Shop" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="YourNamespace.Shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Shop</h2>
    <table>
        <tr>
            <td>Naziv:</td>
            <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Opis:</td>
            <td><asp:TextBox ID="txtDescription" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnSave" runat="server" Text="Spremi" OnClick="btnSave_Click" />
            </td>
        </tr>
    </table>

    <asp:GridView ID="GridViewProducts" runat="server" AutoGenerateColumns="True"></asp:GridView>
</asp:Content>
