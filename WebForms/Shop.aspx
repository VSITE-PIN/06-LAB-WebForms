<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!DOCTYPE html>
<html lang="hr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registracija</title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
             Naziv: <asp:TextBox ID="Naziv" runat="server"></asp:TextBox>
            <br />
             <br />
             Opis: <asp:TextBox ID="Opis" runat="server"></asp:TextBox>
            <br />
             <br />
             <br />
             <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <asp:GridView ID="gvProducts" runat="server"></asp:GridView>
            <br />
            <asp:Button ID="btnDisplay" runat="server" Text="Prikaži proizvode" OnClick="btnDisplay_Click" Width="150px" />

    </div>
    </form>
</body>
</html>
</asp:Content>
