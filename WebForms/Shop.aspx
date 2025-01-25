<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Shop</h1>
    <br />
    <br />
    <br />
    Naziv: <asp:TextBox ID="Naziv" runat="server"></asp:TextBox>
    <br />
    <br />
    Opis: <asp:TextBox ID="Opis" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Spremi" runat="server" Text="Spremi" OnClick="Spremi_Click" />
    <br />
    <br />
    <br />
    <asp:GridView ID="Elementi" runat="server"></asp:GridView>
</asp:Content>
