using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class ЛР6_WebUserControl2 : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Sum(object sender, EventArgs e)
    {
        try {
            double a = Convert.ToDouble(Num1.Text.ToString());
            double b = Convert.ToDouble(Num2.Text.ToString());
            double c=a+b;
            itog.Text = c.ToString();
        }
        catch {
            itog.Text = "Ошибка: введены недопустимые значения!!!";
        }
    }
}
