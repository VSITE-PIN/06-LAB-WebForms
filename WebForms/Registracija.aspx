<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="WebForms.Registracija" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Registriraj se</p>
    <p>
        Korisnicko ime:<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    </p>
    <p>
        Puno ime:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Lozinka:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        Ponavljena lozinka:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="RegButton" runat="server" OnClick="Button1_Click" Text="Registriraj se" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>

</asp:Content>
