<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>
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
            <h1>Login</h1>
            <br />
            <br />
             Korisničko ime:<asp:TextBox ID="KorisničkoIme" runat="server"></asp:TextBox>
             <br />
             <br />
             Lozinka:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <br />
             <br />
             <asp:Button ID="Prijava" runat="server" Text="Prijavi se" OnClick="Prijava_Click" />


    </div>
    </form>
</body>
</html>





</asp:Content>
