<%@ Page Title="Shop" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Shop</h2>

    <asp:Label runat="server" Text="Naziv:" AssociatedControlID="txtName" />
    <asp:TextBox ID="txtName" runat="server" />
    <br /><br />

    <asp:Label runat="server" Text="Opis:" AssociatedControlID="txtDesc" />
    <asp:TextBox ID="txtDesc" runat="server" />
    <br /><br />

    <asp:Button ID="btnSave" runat="server" Text="Spremi proizvod" OnClick="btnSave_Click" />
    <br /><br />

    <asp:Label ID="lblMsg" runat="server" />
    <hr />

    <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="true" />
</asp:Content>
