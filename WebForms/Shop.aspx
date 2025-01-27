<asp:Label ID="lblName" runat="server" Text="Product Name:"></asp:Label>
<asp:TextBox ID="tbName" runat="server"></asp:TextBox>
<br />
<asp:Label ID="lblDescription" runat="server" Text="Product Description:"></asp:Label>
<asp:TextBox ID="tbDescription" runat="server"></asp:TextBox>
<br />
<asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
<br />
<asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="True"></asp:GridView>
