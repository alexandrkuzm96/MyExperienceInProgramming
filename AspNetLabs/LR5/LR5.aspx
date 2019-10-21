<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LR5.aspx.cs" Inherits="LR5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div id="content" class="content">
    <asp:Label runat="server" CssClass="simbols" Text="Введите дату дд.мм.гггг" />
    <asp:TextBox runat="server" CssClass="textbox passwd" ID="date" />
    <asp:RegularExpressionValidator ID="regexpval" runat="server"
    ControlToValidate="date"
    ValidationExpression="\d{1,2}[.]\d{1,2}[.]\d{4}"
    Display="Dynamic" 
    EnableClientScript="false"
    ErrorMessage="* Вы неправильно ввели дату!">*</asp:RegularExpressionValidator><br />
    <asp:Label runat="server" CssClass="simbols" Text="Введите чисо" />
    <asp:TextBox runat="server" CssClass="textbox" ID="onlynum" />
    <asp:RegularExpressionValidator id="RegularExpressionValidator1" 
     ControlToValidate="onlynum"
     ValidationExpression="\d*"
     Display="Dynamic"
     EnableClientScript="false"
     ErrorMessage="* Можно вводить только цифры!"
     runat="server">*</asp:RegularExpressionValidator><br />
     <asp:Label runat="server" CssClass="simbols" Text="Введите мобильный номер телефона
     в формате +7(999)999-99-99" /><br />
     <asp:TextBox runat="server" CssClass="textbox passwd" ID="telephonnumber" />
     <asp:RegularExpressionValidator runat="server" ID="regexpval2"
     ControlToValidate="telephonnumber"
     ValidationExpression="\+\d{1}\(\d{3}\)\s?\d{3}-\d{2}-\d{2}"
     Display="Dynamic"
     EnableClientScript="false"
     ErrorMessage="* Номер введн неправильно !">*</asp:RegularExpressionValidator><br/><br />
     <asp:TextBox runat="server" ID="textbox1" CssClass="textbox passwd" Text="Введите сюда текст" /><br />
     <asp:Label runat="server" ID="label1" /><br />
     <asp:TextBox runat="server" ID="textbox2" CssClass="textbox passwd" Text="Введите сюда текст" /><br />
     <asp:Label runat="server" ID="label2" /><br />
     <asp:TextBox runat="server" ID="textbox3" CssClass="textbox passwd" Text="Введите сюда текст" /><br />
     <asp:Label runat="server" ID="label3" /><br />
          <asp:TextBox runat="server" ID="textbox4" CssClass="textbox passwd" Text="Введите сюда слово" /><br />
     <asp:Label runat="server" ID="label4" /><br />
    <asp:Button runat="server" CssClass="buttons" Text="Проверить" OnClick="MyFunction" />
    <asp:ValidationSummary id="valSummary" runat="server"
    HeaderText="Ошибка"
    ShowSummary="true" DisplayMode="List" /><br />
    <ul><li><a href="LR5Part2.aspx">Страница 2</a></li>
    <li><a href="../Soderjanie.aspx">Содержание</a></li></ul>
    
    </div>
    </form>
</body>
</html>
