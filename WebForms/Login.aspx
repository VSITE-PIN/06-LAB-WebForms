<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div>
        <asp:Label ID="Label1" runat="server" Text="Korisnicko Ime:"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    </div> 
    <div>
         <asp:Label ID="Label3" runat="server" Text="Lozinka:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    </div>  
    <div>
        <asp:Button ID="LoginButton" runat="server" Text="Prijava"  OnClick="LoginButton_Click"/>
        <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
