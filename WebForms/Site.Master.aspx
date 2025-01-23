<%@ Master Language="C#" AutoEventWireup="true" CodeBehind="Site.Master.cs" Inherits="YourNamespace.Site" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title><asp:ContentPlaceHolder ID="TitleContent" runat="server" /></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ContentPlaceHolder ID="MainContent" runat="server" />
    </form>
</body>
</html>
