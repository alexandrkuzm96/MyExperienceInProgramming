using System;
using System.Web.UI;
using System.IO;

public partial class Credit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            // Заполнить список доступными темами, прочитав папки внутри App_Themes
            DirectoryInfo themeDir = new DirectoryInfo(Server.MapPath("../App_Themes"));
            lstThemes.DataTextField = "Name";
            lstThemes.DataSource = themeDir.GetDirectories();
            lstThemes.DataBind();
        }
    }
    protected void Dark_Theme(object sender, EventArgs e)
    {
        // Установить выбранную тему
        Session["Theme"] = lstThemes.SelectedValue;

        // Обновить страницу
        Server.Transfer(Request.FilePath);
    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["Theme"] == null)
        {
            // Тема не выбрана
            Page.Theme = "";
        }
        else
        {
            Page.Theme = (string)Session["Theme"];
        }
    }
    protected void SumCredit_Click(object sender, EventArgs e)
    {
        try
        {
            double sum, p, su;
            TimeSpan days = Creditnd.SelectedDate.Date - Creditstart.SelectedDate.Date;
            su = Convert.ToDouble(Sum.Text.ToString());
            p = Convert.ToDouble(Prosent.SelectedValue.ToString());
            sum = su * p * days.Days + su;
            ItogSum.Text = "К выплате" + sum.ToString();
        }
        catch (Exception ex)
        {
            ItogSum.Text = (ex.Message.ToString() + " " + ex.Source.ToString());
        }
    }
}
