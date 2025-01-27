<%@ Page Title="Shop" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Shop</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Welcome to the Shop!</h2>

    <!-- Prikaz proizvoda -->
    <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" EmptyDataText="No products available." OnRowDeleting="gvProducts_RowDeleting" DataKeyNames="Id">
    <Columns>
        <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
        <asp:BoundField DataField="Name" HeaderText="Product Name" />
        <asp:BoundField DataField="Description" HeaderText="Description" />
        <asp:CommandField ShowDeleteButton="True" />
    </Columns>
</asp:GridView>


    <!-- Forma za unos novog proizvoda -->
    <h3>Add New Product</h3>
    <asp:TextBox ID="txtProductName" runat="server" Placeholder="Product Name"></asp:TextBox><br />
    <asp:TextBox ID="txtProductDescription" runat="server" Placeholder="Description"></asp:TextBox><br />
    <asp:Button ID="btnAddProduct" runat="server" Text="Add Product" OnClick="btnAddProduct_Click" />

    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>
