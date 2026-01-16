<%@ Page Title="Shop" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Shop</h2>

    <asp:Label ID="lblWelcome" runat="server" CssClass="fw-bold"></asp:Label>
    <br /><br />

    <h4>Dodaj novi proizvod</h4>

    <asp:Label ID="lblMsg" runat="server" CssClass="text-danger"></asp:Label>

    <div class="mb-3">
        <asp:Label runat="server" AssociatedControlID="tbName" Text="Naziv proizvoda"></asp:Label>
        <asp:TextBox ID="tbName" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="mb-3">
        <asp:Label runat="server" AssociatedControlID="tbDescription" Text="Opis proizvoda"></asp:Label>
        <asp:TextBox ID="tbDescription" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <asp:Button ID="btnAdd" runat="server" Text="Dodaj proizvod" CssClass="btn btn-primary" OnClick="btnAdd_Click" />

    <hr />

    <asp:GridView ID="gvProducts" runat="server" CssClass="table table-striped"></asp:GridView>
</asp:Content>
