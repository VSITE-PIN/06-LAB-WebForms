<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2>Shop</h2>
    <table>
        <tr>
            <td>
                <asp:Label ID="lblName" runat="server" Text="Naziv:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server" Text="Opis:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnSave" runat="server" Text="Spremi" OnClick="btnSave_Click" />
            </td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="True"></asp:GridView>
</asp:Content>
