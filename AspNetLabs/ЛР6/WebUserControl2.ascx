<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl2.ascx.cs" Inherits="ЛР6_WebUserControl2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script language="javascript" type="text/javascript">

</script>
<asp:TextBox runat="server" ID="Num1" CssClass="textbox" />
<asp:label runat="server" Text="+" CssClass="simbols" />
<asp:TextBox ID="Num2" CssClass="textbox" runat="server" />
<asp:Label runat="server" Text="=" CssClass="simbols"/>
<asp:Label runat="server" ID="itog" CssClass="simbols"/><br />
<asp:button runat="server" Text="Расчитать" CssClass="buttons sum" OnClick="Sum"/>
