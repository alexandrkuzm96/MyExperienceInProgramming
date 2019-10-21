using System;
using System.Web.UI;
using System.IO;

public partial class Default2 : System.Web.UI.Page
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

    protected void Weight_Click(object sendr, EventArgs e)
    {
        try
        {
            int a1 = Convert.ToInt32(Age.SelectedValue.ToString());
            int r1 = Convert.ToInt32(Rost.Text.ToString());
            int w1 = Convert.ToInt32(Weight.Text.ToString());
            Weight_(a1, r1, w1);
        }
        catch (Exception ex)
        {
            Itog.Text = "Вы не заполнили некоторые поля!!!";
        }

    }

    protected void Weight_(int a, int r, int w)
    {
        try
        {
            a = Convert.ToInt32(Age.SelectedValue.ToString());
            r = Convert.ToInt32(Rost.Text.ToString());
            w = Convert.ToInt32(Weight.Text.ToString());
            if (a == 1)
            {
                int k = w - (r - 110);
                if (k > 5)
                {
                    Itog.Text = "Итог: вес избыточен.";
                }
                else
                {
                    if (k < -5)
                    {
                        Itog.Text = "Итог: вес недостаточен.";
                    }
                    else { Itog.Text = "Итог: вес в норме."; }
                }
            }
            if (a == 2)
            {
                int k = w - (r - 100);
                if (k > 5)
                {
                    Itog.Text = "Итог: вес избыточен.";
                }
                else
                {
                    if (k < -5)
                    {
                        Itog.Text = "Итог: вес недостаточен.";
                    }
                    else { Itog.Text = "Итог: вес в норме."; }
                }
            }
            if (a == 0)
            {
                Itog.Text = "Извините, расчеты ведутся только для взрослых";
            }
        }
        catch (Exception ex)
        {
            Itog.Text = "Вы не заполнили некоторые поля!!!";
        }
    }
    protected void Clear_Click(object sendr, EventArgs e) 
    {
        Rost.Text = null;
        Weight.Text = null;
        Itog.Text ="Итог";
    }
}
