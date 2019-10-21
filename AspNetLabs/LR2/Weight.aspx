<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Weight.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link type="text/css" rel="stylesheet" href="../App_Themes/GeneralStyle/GeneralStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="content" class="content">
            <asp:ListBox ID="lstThemes" CssClass="Listbox" runat="server">
    </asp:ListBox>
<br /><br />
    <asp:Button ID="Dark" 
    CssClass="buttons" Text="Сменить тему" runat="server" OnClick="Dark_Theme" /><br /><br />
    <asp:Label CssClass="simbols" ID="YourOld" runat="server" Text="Ваш возраст" />
    <asp:DropDownList CssClass="dropdownlist" ID="Age" runat="server">
    <asp:ListItem Text="Меньше 18" Value="0" />
    <asp:ListItem Text="От 18 до 50" Value="1" />
    <asp:ListItem Text="Больше 50" Value="2" />
    </asp:DropDownList><br />
    <asp:Label runat="server" CssClass="simbols" ID="YourRost" Text="Ваш рост" />
    <asp:TextBox runat="server" CssClass="textbox" ID="Rost" /><br />
    <asp:Label runat="server" CssClass="simbols" ID="YourWeight" Text="Ваш вес" />
    <asp:TextBox runat="server" CssClass="textbox" ID="Weight"/><br />
    <asp:Button runat="server" CssClass="buttons" ID="Calculat" Text="Расчитать" OnClick="Weight_Click" />
    <asp:Label runat="server" CssClass="simbol" ID="Itog" Text="Итог" /><br />
    <asp:Button runat="server" CssClass="buttons" ID="Clear" Text="Очистить" OnClick="Clear_Click" />
    <ul>
    <li><a href="Credit.aspx">Страница 2</a></li>
    <li><a href="../Soderjanie.aspx"> Содержание</a></li>
    </ul>
    </div>
    </form>
</body>
</html>
