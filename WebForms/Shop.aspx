<%@ Page Title="Shop"
    Language="C#"
    MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Shop.aspx.cs"
    Inherits="WebForms.Shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Shop</h2>

    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
    <br /><br />

    <table>
        <tr>
            <td>Naziv:</td>
            <td><asp:TextBox ID="txtName" runat="server" /></td>
        </tr>
        <tr>
            <td>Opis:</td>
            <td><asp:TextBox ID="txtDescription" runat="server" /></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnSave"
                            runat="server"
                            Text="Spremi"
                            OnClick="btnSave_Click" />
            </td>
        </tr>
    </table>

    <br />

    <asp:GridView ID="gvProducts" runat="server" />

</asp:Content>
