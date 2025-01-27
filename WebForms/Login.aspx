<asp:Label ID="lblUserName" runat="server" Text="User Name:"></asp:Label>
<asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
<asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
<br />
<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
<asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
