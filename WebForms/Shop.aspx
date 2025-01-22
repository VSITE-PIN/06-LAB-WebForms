<%@ Page Title="Trgovina" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Dodavanje proizvoda</h2>
    <asp:TextBox ID="txtProductName" runat="server" Placeholder="Naziv proizvoda"></asp:TextBox><br />
    <asp:TextBox ID="txtProductDescription" runat="server" Placeholder="Opis proizvoda"></asp:TextBox><br />
    <asp:Button ID="btnSaveProduct" runat="server" Text="Spremi" OnClick="btnSaveProduct_Click" /><br />
    <asp:GridView ID="gvProducts" runat="server"></asp:GridView>
</asp:Content>
