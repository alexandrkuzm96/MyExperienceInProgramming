using System;
using System.Web.UI;
using System.Text.RegularExpressions;

public partial class LR5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "GeneralStyle";
    }
    protected void MyFunction(object sender, EventArgs e)
    {
        label2.Text = "";
        Textbox1_Doing();
        Textbox2_Doing();
        Textbox3_Doing();
        Textbox4_Doing();
    }
    protected void Textbox1_Doing()
    {
        /*Действия для textbox1*/
        string text1 = textbox1.Text; 
        string str1 = @"[а-яА-Я]\w*";
        Regex reg1 = new Regex(str1);
        Match t1 = reg1.Match(text1);
        int ch = 0;
        if(t1.Success)
        {
            ch = ch+1;
            label1.Text = "Русские слова найдены";
            }
            else { label1.Text = "Русские слова не найдены"; }
    }
    protected void Textbox2_Doing()
    {
        /*Действия для textbox2*/
        string text2 = textbox2.Text;
        string str2 = @"(А|а)\w{2,}(\b|\s|[\.\,\;\:]|$)+";
        Regex reg2 = new Regex(str2);
        Match t2 = reg2.Match(text2);
        while (t2.Success)
        {
            label2.Text = label2.Text + "," + t2.Value;
            t2 = t2.NextMatch();
        }
    }
    protected void Textbox3_Doing()
    {
        /*Действия для textbox3*/
        string text3 = textbox3.Text;
        string str3 = @"(^|\b|\s|[\.\,\;\:])+\w{5}(\s|\S[\.\,\;\:]|\b|$)+";
        Regex reg3 = new Regex(str3);
        Match t3 = reg3.Match(text3);
        int n = 0;
        while (t3.Success)
        {
            n = n + 1;
            t3 = t3.NextMatch();
        }
        label3.Text = "Число слов из 5ти букв " + n.ToString();
    }
    protected void Textbox4_Doing()
    {
        /*Действия для textbox4*/
        string text4 = textbox4.Text;
        string p = @"О|о";
        string p1 = @"А";
        string itog4 = Regex.Replace(text4, p, p1);
        label4.Text = itog4;
    }
}
