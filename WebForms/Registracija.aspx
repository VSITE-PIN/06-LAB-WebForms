<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="WebForms.Registracija" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div> 
        Korisničko ime: <asp:TextBox ID="tbKi" runat="server"></asp:TextBox> <br /> <br />
        Puno ime: <asp:TextBox ID="tbIme" runat="server"></asp:TextBox> <br /> <br />
        Lozinka: <asp:TextBox ID="tbLozinka" TextMode="Password" runat="server"></asp:TextBox> <br /> <br />
        Ponovljena lozinka: <asp:TextBox ID="tbPonovljenaLozinka" TextMode="Password" runat="server"></asp:TextBox> <br /> <br />
        
        <asp:Button ID="Register" runat="server" Text="Registriraj" OnClick="btnRegister_Click" Height="22px" Width="115px" /> <br /> <br />
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>

        <hr />
        <asp:GridView ID="gvUsers" runat="server">
        </asp:GridView>
        <hr />
    </div>
</asp:Content>


