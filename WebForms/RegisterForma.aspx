<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterForma.aspx.cs" Inherits="WebForms.RegisterForma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Password1 {
            margin-left: 32px;
        }
        #Password2 {
            margin-left: 32px;
        }
        #Text1 {
            margin-left: 21px;
        }
        #Text2 {
            margin-left: 21px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Registriraj se"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Korisnicko ime"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 34px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Puno ime"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 34px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Lozinka"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 34px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Ponovi lozinku"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 34px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
<asp:Button ID="Button1" runat="server" Text="Registracija" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
