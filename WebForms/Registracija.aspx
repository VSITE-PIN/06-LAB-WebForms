<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="WebForms.Registracija" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

    <h3>Registracija</h3>
<p>
    Korisničko ime:
    <asp:TextBox ID="txtImeReg" runat="server"></asp:TextBox>
</p>
<p>
    Puno ime:
    <asp:TextBox ID="ImeReg" runat="server"></asp:TextBox>
</p>
<p>
    Lozinka:
    <asp:TextBox ID="txtLozinkaReg" runat="server"></asp:TextBox>
</p>
<p>
    Ponovljena lozinka:
    <asp:TextBox ID="txtPonReg" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnReg" runat="server" OnClick="btnReg_Click" Text="Registriraj se" />
</p>
    

</asp:Content>
