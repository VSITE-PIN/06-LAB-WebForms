<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>

<!DOCTYPE html>
<html>
<head>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Prijava korisnika</h2>

        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br /><br />

        <asp:Label ID="lblUsername" runat="server" Text="Korisničko ime: "></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br /><br />

        <asp:Label ID="lblPassword" runat="server" Text="Lozinka: "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />

        <asp:Button ID="btnLogin" runat="server" Text="Prijava" OnClick="btnLogin_Click" />
    </form>
</body>
</html>
