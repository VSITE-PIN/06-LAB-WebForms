<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div>
        <asp:Label ID="Label1" runat="server" Text="Naziv:"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Opis:"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
    </div> 
    <div>
        <asp:Button ID="AddProduct" runat="server" Text="Spremi" OnClick="AddProduct_Click" />
    </div>
    <div>
        <asp:GridView ID="GridViewProducts" runat="server"></asp:GridView>
    </div>
</asp:Content>
