<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Shop</h2>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" HeaderStyle-BackColor="LightGray">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" />
            <asp:BoundField DataField="Name" HeaderText="Naziv" />
            <asp:BoundField DataField="Description" HeaderText="Opis" />
        </Columns>
    </asp:GridView>

    <h3>Add New Product</h3>
    <label for="txtNaziv">Naziv:</label>
    <asp:TextBox ID="txtNaziv" runat="server"></asp:TextBox>
    <br />
    <label for="txtOpis">Opis:</label>
    <asp:TextBox ID="txtOpis" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnSpremi" Text="Spremi" runat="server" OnClick="btnSpremi_Click" />
</asp:Content>
