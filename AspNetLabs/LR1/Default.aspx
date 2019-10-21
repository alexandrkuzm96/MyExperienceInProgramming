<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>My page</title>
    <link type="text/css" rel="stylesheet" href="Style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="content" class="content">
    <asp:ListBox ID="lstThemes" CssClass="Listbox" runat="server">
    </asp:ListBox>
<br /><br />
    <asp:Button ID="Dark" 
    CssClass="buttons" Text="Сменить тему" runat="server" OnClick="Dark_Theme" /><br /><br />
    <h1 id="zogolovok">Кузьин Александр Валерьевич ПИ-114</h1>
    <div class="clock">
    <asp:Label id="Time" runat="server" Text="Время: "/> <br />
    <asp:Button ID="button1" runat="server" Text="Обновить время" OnClick="button1_Click"/><br />
    </div>
    <ul>
    <li><a href="Table.aspx">Страница 2</a></li>
    <li><a href="../Soderjanie.aspx">Содержание</a></li>
    </ul>
    </div>
    </form>
</body>
</html>
