<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Shop</h2>
    <div>
        <asp:Label ID="lblName" runat="server" Text="Naziv proizvoda:"></asp:Label><br />
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblDescription" runat="server" Text="Opis proizvoda:"></asp:Label><br />
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="btnAdd" runat="server" Text="Dodaj proizvod" OnClick="btnAdd_Click" /><br /><br />
        <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="True"></asp:GridView>
    </div>
</asp:Content>