<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Credit.aspx.cs" Inherits="Credit" Theme="GeneralStyle" %>

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
    CssClass="buttons" Text="Сменить тему" runat="server" OnClick="Dark_Theme" />
    <asp:Label runat="server" CssClass="simbols" Text="Сумма кредита"/>
    <asp:TextBox runat="server" CssClass="textbox" ID="Sum"/><br />
    <asp:Label runat="server" CssClass="simbols" Text="Процентная ставка"/>
    <asp:DropDownList CssClass="dropdownlist" runat="server" ID="Prosent">
    <asp:ListItem Text="10%" Value="0,1" />
    <asp:ListItem Text="14%" Value="0,14" />
    <asp:ListItem Text="16%" Value="0,16" />
    </asp:DropDownList><br />
    <asp:Label runat="server" CssClass="simbols" text="Дата полчения кредита"/>
    <asp:Calendar runat="server" CssClass="celendar" ID="Creditstart"/><br />
    <asp:Label ID="Label1" CssClass="simbols" runat="server" text="Дата погашения кредита"/>
    <asp:Calendar runat="server" CssClass="celendar" ID="Creditnd"/><br />
    <asp:Button runat="server" CssClass="buttons" Text="Расчитать" ID="Calculate" OnClick="SumCredit_Click"/><br />
    <asp:Label runat="server"  CssClass="simbols" Text="Сумма для погашения:" ID="ItogSum"/>
    <ul>
    <li><a href="Weight.aspx">Страница 1</a></li>
    <li><a href="../Soderjanie.aspx">Содержание</a></li>
    </ul>
    </div>
    </form>
</body>
</html>
