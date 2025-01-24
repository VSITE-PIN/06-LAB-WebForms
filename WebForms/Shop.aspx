<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Shop</title>
    <style type="text/css">
        .form-container {
            margin: 20px;
        }
        .grid-container {
            margin-top: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>Dodaj Novi Proizvod</h2>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Naziv proizvoda:" />
                <asp:TextBox ID="TextBoxNaziv" runat="server" />
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Opis proizvoda:" />
                <asp:TextBox ID="TextBoxOpis" runat="server" Rows="1" Height="16px" Width="145px" />
            </p>
            <p>
                <asp:Button ID="ButtonSpremi" runat="server" Text="Spremi" OnClick="ButtonSpremi_Click" />
            </p>
        </div>
        <div class="grid-container">
            <h2>Proizvodi</h2>
            <asp:GridView ID="GridViewProizvodi" runat="server" AutoGenerateColumns="true" />
        </div>
    </form>
</body>
</html>