<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <p>
        Naziv
        <asp:TextBox ID="tbShopNaziv" runat="server"></asp:TextBox>
    </p>
    <p>
        Opis
        <asp:TextBox ID="tbShopOpis" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btSpremi" runat="server" Text="Spremi" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" HeaderStyle-BackColor="LightGray">
    <Columns>
        <asp:BoundField DataField="Id" HeaderText="ID" />
        <asp:BoundField DataField="Name" HeaderText="Name" />
        <asp:BoundField DataField="Description" HeaderText="Description" />
    </Columns>
</asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </p>
    
</asp:Content>
