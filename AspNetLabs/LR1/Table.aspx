<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <link type="text/css" rel="stylesheet" href="Style.css/" />
    <title>Table</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="content" class="content">
    <asp:Table ID="Table" runat="server">
    <asp:TableRow CssClass="Rows">
        <asp:TableCell CssClass="Cell1" style="width:200px;" />
        <asp:TableCell CssClass="Cell2" style="width:auto;"/>
        <asp:TableCell CssClass="Cell3" style="width:auto;"/>
    </asp:TableRow>
        <asp:TableRow CssClass="Rows">
        <asp:TableCell CssClass="Cell1" style="width:200px;" />
        <asp:TableCell CssClass="Cell2" style="width:auto;"/>
        <asp:TableCell CssClass="Cell3" style="width:auto;"/>
    </asp:TableRow>
        <asp:TableRow CssClass="Rows">
        <asp:TableCell CssClass="Cell1" style="width:200px;" />
        <asp:TableCell CssClass="Cell2" style="width:auto;" />
        <asp:TableCell CssClass="Cell3" style="width:auto;"/>
    </asp:TableRow>
    </asp:Table>
    <ul>
    <li><a href="Default.aspx">Назад</a></li>
    <li><a href="../Soderjanie.aspx">Содержание</a></li>
    </ul>
    </div>
    </form>
</body>
</html>
