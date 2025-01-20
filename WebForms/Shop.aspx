<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Shop</h2>
    <asp:TextBox ID="txtProductName" runat="server" Placeholder="Product Name"></asp:TextBox><br />
    <asp:TextBox ID="txtProductDescription" runat="server" Placeholder="Product Description"></asp:TextBox><br />
    <asp:Button ID="btnAddProduct" runat="server" Text="Add Product" OnClick="btnAddProduct_Click" /><br />
    <asp:GridView ID="gvProducts" runat="server"></asp:GridView>
</asp:Content>

