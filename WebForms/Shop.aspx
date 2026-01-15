<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Trgovina</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Popis proizvoda</h2>
            <asp:GridView ID="gvProducts" runat="server"></asp:GridView>
            
            <hr />
            <h3>Dodaj novi proizvod</h3>
            <div>
                <label>Naziv proizvoda:</label><br />
                <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Opis:</label><br />
                <asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox>
            </div>
            <br />
            <asp:Button ID="btnAddProduct" runat="server" Text="Dodaj proizvod" OnClick="btnAddProduct_Click" />
            <br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>