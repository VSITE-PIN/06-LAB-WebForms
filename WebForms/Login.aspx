<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Prijava</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Prijava</h2>
            <hr />
            <div>
                <label>Korisničko ime:</label><br />
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Lozinka:</label><br />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Prijavi se" OnClick="btnLogin_Click" />
            <br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>