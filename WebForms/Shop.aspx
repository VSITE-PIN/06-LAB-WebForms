<%@ Page Title="Shop" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebFormsLab.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <h2>Shop</h2>
  Naziv: <asp:TextBox ID="tbProductName" runat="server"></asp:TextBox><br />
  Opis: <asp:TextBox ID="tbDescription" runat="server"></asp:TextBox><br />
  <asp:Button ID="btnSave" runat="server" Text="Spremi" OnClick="btnSave_Click" /><br />
  <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="true"></asp:GridView>
</asp:Content>
