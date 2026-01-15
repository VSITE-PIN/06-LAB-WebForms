<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebForms.Registration" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registracija</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />

        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        <br /><br />

        <table>
            <tr>
                <td>Korisničko ime:</td>
                <td><asp:TextBox ID="txtUserName" runat="server" /></td>
            </tr>
            <tr>
                <td>Puno ime:</td>
                <td><asp:TextBox ID="txtFullName" runat="server" /></td>
            </tr>
            <tr>
                <td>Lozinka:</td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /></td>
            </tr>
            <tr>
                <td>Ponovljena lozinka:</td>
                <td><asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" /></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnRegister" runat="server" Text="Registriraj" OnClick="btnRegister_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>