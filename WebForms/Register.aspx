<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebFormsLab.Registration" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registracija</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Registracija</h2>
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label><br />
            <asp:Label ID="lblUserName" runat="server" Text="Korisničko ime:"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblPassword" runat="server" Text="Lozinka:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Label ID="lblFullName" runat="server" Text="Puno ime:"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnRegister" runat="server" Text="Registriraj se" OnClick="btnRegister_Click" />
        </div>
    </form>
</body>
</html>
