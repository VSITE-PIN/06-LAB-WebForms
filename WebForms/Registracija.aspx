<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="WebForms.Registracija" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Korisnicko Ime:"></asp:Label>
        <input id="txtUsername1" type="text" />
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Puno Ime:"></asp:Label>
        <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
    </div> 
    <div>
         <asp:Label ID="Label3" runat="server" Text="Lozinka:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    </div> 
    <div>
        <asp:Label ID="Label4" runat="server" Text="Ponovljena lozinka:"></asp:Label>
         <asp:TextBox ID="txtRepeatedPassword" runat="server"></asp:TextBox>
    </div>  
    <div>
        <asp:Button ID="RegisterButton" runat="server" Text="Registriraj" OnClick="RegisterButton_Click" />
        <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>

    </div>
    
</asp:Content>
