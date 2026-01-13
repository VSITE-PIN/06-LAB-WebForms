<%@ Page Title="Shop" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebFormsLab6.Shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Shop</h2>

    <p>
        Naziv:
        <asp:TextBox ID="txtName" runat="server" />
    </p>
    <p>
        Opis:
        <asp:TextBox ID="txtDesc" runat="server" TextMode="MultiLine" Rows="3" />
    </p>

    <asp:Button ID="btnSave" runat="server" Text="Spremi" OnClick="btnSave_Click" />
    <br /><br />
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />
    <br /><br />

    <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" GridLines="Both">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Description" HeaderText="Description" />
        </Columns>
    </asp:GridView>
</asp:Content>
