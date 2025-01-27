<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>

<!DOCTYPE html>
<html>
<head>
    <title>Shop</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Shop</h2>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br />

        <!-- Polje za unos proizvoda -->
        <div>
            <asp:Label ID="lblProductName" runat="server" Text="Naziv proizvoda: "></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="lblProductDescription" runat="server" Text="Opis proizvoda: "></asp:Label>
            <asp:TextBox ID="txtProductDescription" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox><br /><br />

            <asp:Button ID="btnSave" runat="server" Text="Spremi proizvod" OnClick="btnSave_Click" />
        </div>

        <hr />

        <!-- Prikaz proizvoda u GridView -->
        <asp:GridView ID="GridViewProducts" runat="server" AutoGenerateColumns="True"></asp:GridView>

    </form>
</body>
</html>
