<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style type="text/css">
       {
            margin-left: 28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Login</h2>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Korisnicko ime"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" />
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Lozinka"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" />
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Prijava" OnClick="Button1_Click" />
            </p>
            <p>
                <asp:Label ID="LoginMessage" runat="server" ForeColor="Red" />
            </p>
        </div>
    </form>
</body>
</html>
