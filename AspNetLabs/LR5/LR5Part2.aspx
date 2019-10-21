<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LR5Part2.aspx.cs" Inherits="LR5_LR5Part2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>

</head>
<body>
    <form id="form1" runat="server">
    <div id="content" class="content">
    <asp:TextBox runat="server" class="textbox" ID="textbox1" />
    <asp:Label runat="server" CssClass="simbols" Text="/"  ID="label1" />
    <asp:TextBox runat="server" CssClass="textbox" ID="textbox2" />
    <asp:Label runat="server" CssClass="simbols" Text="=" ID="label2" />
    <asp:Label runat="server" CssClass="simbols" ID="label3" /><br />
    <asp:Button runat="server" CssClass="buttons" ID="button1" Text="Расчитать" OnClick="Divided" /><br />
    <ul><li><a href="LR5.aspx">Страница1</a></li>
    <li><a href="../Soderjanie.aspx">Содержание</a></li></ul>
    </div>
    </form>
</body>
</html>
