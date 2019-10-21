<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Password.aspx.cs" Inherits="Password" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<script language='javascript' type="text/javascript">
function yourbournyear(oSrc,args)
{
    var x = document.form1.elements.namedItem('bourndate').value;
    var y;
    y =2017-x;
    alert(y);
    if (y < 13) {
        args.IsValid = false;
    }
    else {
        args.IsValid = true;
    }

}
</script>
<body>
    <form id="form1" runat="server">
    <div id="content" class="content">
    <asp:Label runat="server" CssClass="simbols" Text="������ ������" />
    <asp:TextBox runat="server" CssClass="textbox passwd" ID="OldPassword" />
    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator" ControlToValidate="OldPassword"
    ErrorMessage="* ������. �� ������� ������������ ����"  Display="Dynamic">!!!
    </asp:RequiredFieldValidator><br />
    <asp:Label runat="server" CssClass="simbols p" Text="����� ������"/>
    <asp:TextBox  runat="server" CssClass="textbox passwd" ID="newpassword"/><br />
    <asp:Label ID="Label1" runat="server" CssClass="simbols" Text="��������� ����� ������"/>
    <asp:TextBox  runat="server" CssClass="textbox passwd" ID="repiatnewpassword"/>
    <asp:CompareValidator runat="server" ID="valcompair" ControlToValidate="newpassword"
    ControlToCompare="repiatnewpassword" Operator="Equal" ErrorMessage="* �������� 
    � ��������� ���� 1 � 2 ������ ���� �����������" Display="dynamic">!!!
    </asp:CompareValidator><br />
    <asp:Label runat="server" CssClass="simbols" Text="��� �������" />
    <asp:TextBox runat="server" CssClass="textbox" id="yourold" />
    <asp:CompareValidator runat="server" ID="comval"
    ControlToValidate="yourold"
    ValueToCompare="13"
    Type="integer" Operator="GreaterThan"
    ErrorMessage="* �� ������ ���� ������ 13 ���" >!!!</asp:CompareValidator><br />
    <asp:Label ID="Label2" runat="server" CssClass="simbols" Text="���� ��������" />
    <asp:TextBox runat="server" CssClass="textbox" id="bourndate" />
    <asp:CustomValidator id="valCustom" runat="server"
    ControlToValidate="bourndate"
    ClientValidationFunction="yourbournyear"
    OnServerValidate="ServerValidate"
    ErrorMessage="*�������� � ���� ���� ��������" Display="dynamic" >!!!
</asp:CustomValidator>
<br />
    <asp:ValidationSummary id="valSummary" runat="server"
    HeaderText="������"
    ShowSummary="true" DisplayMode="List" />
    <asp:Button runat="server" CssClass="buttons" text="���������" />
    <asp:Label runat="server" ID="itog" />
    <ul>
    <li><a href="../Soderjanie.aspx">����������</a></li></ul>
    </div>
    </form>
</body>
</html>
