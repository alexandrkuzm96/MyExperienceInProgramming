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

public partial class LR5_LR5Part2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "GeneralStyle";
    }
    protected void Divided (object sender, EventArgs e)
    {
        try
        {
            int a = Convert.ToInt32(textbox1.Text.ToString());
            int b = Convert.ToInt32(textbox2.Text.ToString());
            int c = a / b;
            label3.Text = c.ToString();
        }
        catch (System.DivideByZeroException ex)
        {
            label3.Text = "Делить на ноль нельзя!!!";
        }
        catch(Exception ex)
        {
            label3.Text = "Возникла непредвиденная ошибка, проверьте правильность введённых значений";
        }
    }

}
