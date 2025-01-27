<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="formsi.Shop" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Shop</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>SHOP</h3>
            <asp:Label ID="lblNaziv" runat="server" Text="Naziv: "></asp:Label>
            <asp:TextBox ID="txtNaziv" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblOpis" runat="server" Text="Opis: "></asp:Label>
            <asp:TextBox ID="txtOpis" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSpremi" runat="server" Text="Spremi" OnClick="btnSpremi_Click" />
            <br /><br />

            <asp:GridView ID="gvProizvodi" runat="server" AutoGenerateColumns="False" BorderStyle="Solid">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>