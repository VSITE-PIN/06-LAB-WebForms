{
  "exclude": [
    "**/bin",
    "**/bower_components",
    "**/jspm_packages",
    "**/node_modules",
    "**/obj",
    "**/platforms"
  ]
<asp:TextBox ID="txtUser" runat="server" placeholder="Username" /><br />
<asp:TextBox ID="txtPass" runat="server" TextMode="Password" placeholder="Password" /><br />

<asp:Button ID="btnLogin" runat="server" Text="Login"
    OnClick="btnLogin_Click" /><br />

<asp:Label ID="lblMsg" runat="server" ForeColor="Red" />

}