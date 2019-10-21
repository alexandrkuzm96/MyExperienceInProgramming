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
using System.IO;

public partial class Soderjanie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            // Заполнить список доступными темами, прочитав папки внутри App_Themes
            DirectoryInfo themeDir = new DirectoryInfo(Server.MapPath("App_Themes"));
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

}
