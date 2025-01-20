<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebFormsLab.Shop" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trgovina</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Dodavanje proizvoda</h2>
            <asp:Label ID="lblName" runat="server" Text="Naziv proizvoda:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblDescription" runat="server" Text="Opis proizvoda:"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSave" runat="server" Text="Spremi" OnClick="btnSave_Click" /><br /><br />
            <asp:GridView ID="gridProducts" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
