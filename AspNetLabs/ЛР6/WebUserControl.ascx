<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs" Inherits="WebUserControl" %>
<%@ Register TagPrefix="uc" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
</head>
<body>
<div>
<form id="Form1">
<table>
<tr>
<td align="center">
<asp:HyperLink ID="l1" runat="server"  NavigateUrl="~/ЛР6/Default.aspx">Главная</asp:HyperLink>
</td>
<td align="center">
<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ЛР6/Default2.aspx">Страница 1</asp:HyperLink>
</td>
<td align="center">
<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/ЛР6/Default3.aspx">Страница 2</asp:HyperLink>
</td>
<td align="center">
<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Soderjanie.aspx">Содержание</asp:HyperLink>
</td>
</tr>
</table>
</form>
</div>
</body>
</html>

