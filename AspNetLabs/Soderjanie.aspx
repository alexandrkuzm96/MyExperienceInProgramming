<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Soderjanie.aspx.cs" Inherits="Soderjanie"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Содержание</title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div  id="content" class="content">
     <asp:ListBox ID="lstThemes" CssClass="Listbox" runat="server">
         </asp:ListBox>
<br /><br />
    <asp:Button ID="Dark" 
    CssClass="buttons" Text="Сменить тему" runat="server" OnClick="Dark_Theme" />
    <h1 id="zogolovok" >Содержание</h1>
    <ul>
    <li>
    <a href="LR1/Default.aspx">ЛР1</a>
    </li>
    <li><a href="LR2/Weight.aspx">ЛР2</a></li>
    <li><a href="LR3/Password.aspx">ЛР3</a></li>
    <li><a href="LR5/LR5.aspx">ЛР5</a></li>
    <li>
    <a href="ЛР6/Default.aspx">ЛР6</a>
    </li>
    </ul>
    </div>
    </form>
</body>
</html>
