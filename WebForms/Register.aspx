<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebForms.Register" %>

<!DOCTYPE html>
<html>
<head>
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Registracija korisnika</h2>

        <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label><br />

<asp:Label ID="lblUsername" runat="server" Text="Korisničko ime:"></asp:Label>
<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br /><br />

<asp:Label ID="lblPassword" runat="server" Text="Lozinka:"></asp:Label>
<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />

<asp:Label ID="lblFullName" runat="server" Text="Puno ime:"></asp:Label>
<asp:TextBox ID="txtFullName" runat="server"></asp:TextBox><br /><br />

<asp:Button ID="btnRegister" runat="server" Text="Registriraj se" OnClick="btnRegister_Click" />

    </form>
</body>
</html>
