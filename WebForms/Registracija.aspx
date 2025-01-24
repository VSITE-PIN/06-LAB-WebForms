<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="WebForms.Registracija" %>
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
            <h1>Registriraj se</h1>
            <br />
             Korisničko ime: <asp:TextBox ID="KorisničkoIme" runat="server"></asp:TextBox>
            <br />
             <br />
             Puno ime: <asp:TextBox ID="PunoIme" runat="server"></asp:TextBox>
            <br />
             <br />
             Lozinka: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <br />
             <br />
             Ponovljena lozinka:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
             <br />
             <br />
             <asp:Button ID="Registriraj" runat="server" Text="Registriraj" OnClick="Registriraj_Click" />

    </div>
    </form>
</body>
</html>

</asp:Content>
