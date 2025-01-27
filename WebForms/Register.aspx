<asp:Label ID="lblUserName" runat="server" Text="User Name:"></asp:Label>
<asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
<asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
<br />
<asp:Label ID="lblFullName" runat="server" Text="Full Name:"></asp:Label>
<asp:TextBox ID="tbFullName" runat="server"></asp:TextBox>
<br />
<asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
<asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
