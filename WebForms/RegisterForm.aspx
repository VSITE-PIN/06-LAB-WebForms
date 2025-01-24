<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="WebForms.RegisterForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registracija</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="txtUsername">Korisničko ime:</label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />

            <label for="txtPassword">Lozinka:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />

            <label for="txtConfirmPassword">Potvrdi lozinku:</label>
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox><br />

            <asp:Button ID="btnRegister" runat="server" Text="Registruj se" OnClick="btnRegister_Click" />
        </div>
    </form>
</body>
</html>
