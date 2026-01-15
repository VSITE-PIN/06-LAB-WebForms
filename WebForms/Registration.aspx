<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebForms.Registration" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Registracija</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Registriraj se</h2>
            <hr />
            <div>
                <label>Korisničko ime:</label><br />
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Puno ime:</label><br />
                <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Lozinka:</label><br />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <label>Ponovljena lozinka:</label><br />
                <asp:TextBox ID="txtPasswordConfirm" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <br />
            <asp:Button ID="btnRegister" runat="server" Text="Registriraj" OnClick="btnRegister_Click" />
            <br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>