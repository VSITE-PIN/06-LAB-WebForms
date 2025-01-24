﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="YourNamespace.Shop" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>Shop</h2>

    <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label><br />

    Naziv:<br />
    <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox><br /><br />

    Opis:<br />
    <asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox><br /><br />

    <asp:Button ID="btnSaveProduct" runat="server" Text="Spremi" OnClick="btnSaveProduct_Click" /><br /><br />

    <asp:GridView ID="GridViewProducts" runat="server" AutoGenerateColumns="True">
    </asp:GridView>
</asp:Content>