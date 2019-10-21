using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Password : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        
    }
    protected void ServerValidate( object source, ServerValidateEventArgs args)
    {
        args.IsValid = false;
        try
        {
            int d = Convert.ToInt32(bourndate.Text.ToString());
            int t = 2017 - d;
            if (t > 13)
            {
                args.IsValid = true;
            }
            else {
                itog.Text = "Вы не достигли 13 лет";
            }            if (Page.IsValid)
            {
                itog.Text = "Все значения введены верно";
            }
        }
        catch(Exception ex) {
            itog.Text = (itog.Text + " " + ex.Message.ToString() +" " +ex.Source.ToString());
   
        }


    }

}
