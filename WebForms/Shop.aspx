<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
    Naziv:
    <asp:TextBox ID="txtNaziv" runat="server"></asp:TextBox>
</p>
<p>
    Opis:
    <asp:TextBox ID="txtOpis" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnShop" runat="server" OnClick="btnShop_Click" Text="Spremi" />
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">

    </asp:GridView>
    <asp:EntityDataSource ID="EntityDataSource1" runat="server">
    </asp:EntityDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
</p>

</asp:Content>
