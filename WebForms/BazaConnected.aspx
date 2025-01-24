<div>
 ID:<asp:TextBox ID="tbId" runat="server"></asp:TextBox>
 PunoIme:<asp:TextBox ID="tbPunoIme" runat="server"></asp:TextBox>
 Lozinka:<asp:TextBox ID="tbLozinka" runat="server"></asp:TextBox>
 PonovljenaLozinka:<asp:TextBox ID="tbPonovljenaLozinka" runat="server"></asp:TextBox>
 <hr />
 <asp:GridView ID="gvUsers" runat="server">
 </asp:GridView>
 <hr />
 <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
 <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
 <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
 <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
 <asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click"
/>
 <asp:Button ID="btnTotal" runat="server" Text="Total" OnClick="btnTotal_Click" />
 <asp:Label ID="lblTotal" runat="server"></asp:Label>
 </div>