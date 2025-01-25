<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <div> 
        <h2>Shop</h2>
        Naziv:
        <asp:TextBox ID="tbNaziv" runat="server"></asp:TextBox> <br /> <br />
        
        Opis: 
        <asp:TextBox ID="tbOpis" runat="server" ></asp:TextBox> <br /> <br />
        
        <asp:Button ID="btnSpremi" runat="server" Text="Spremi" OnClick="btnSave_Click" /> <br /> <br />
        
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
    </div>
    <asp:GridView ID="gvProducts" runat="server">
    </asp:GridView>
</asp:Content>
