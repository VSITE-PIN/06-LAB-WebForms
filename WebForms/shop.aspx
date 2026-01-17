{
  "exclude": [
    "**/bin",
    "**/bower_components",
    "**/jspm_packages",
    "**/node_modules",
    "**/obj",
    "**/platforms"
  ]
<asp:TextBox ID="txtName" runat="server" placeholder="Product name" /><br />
<asp:RequiredFieldValidator ID="rfv1" runat="server"
    ControlToValidate="txtName"
    ErrorMessage="Name required"
    ForeColor="Red" /><br />

<asp:TextBox ID="txtDesc" runat="server" placeholder="Description" /><br />

<asp:Button ID="btnSave" runat="server" Text="Save"
    OnClick="btnSave_Click" /><br /><br />

<asp:GridView ID="gvProducts" runat="server" />

}