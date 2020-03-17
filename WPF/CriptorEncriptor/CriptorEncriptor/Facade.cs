using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CriptorEncriptor
{
    class Facade
    {
        private IValidator validator = new Validator();
        private  ICripterEncripter cripterEncripter = new CripterEncripter();

        public string CriptText(string userText, string keyWord, int step,
            string criptType)
        {
            string result = "";
            if (criptType == "Caesar"& validator.StepNoNull(step.ToString())&
                validator.ValidateUserMessage(userText))
            {
                result=cripterEncripter.CaesarCripter(step, userText);
            }
            if (criptType == "Vigener"& validator.KeywordNotNull(keyWord)&
                validator.ValidateUserMessage(userText))
            {
                result = cripterEncripter.VigenerCripter(keyWord, userText);
            }
                
            return result;
         }

        public string EncriptText(string userText, string keyWord, int step,
            string criptType)
        {
            string result = "";
            if (criptType == "Caesar" & validator.StepNoNull(step.ToString()) &
                validator.ValidateUserMessage(userText))
            {
                result = cripterEncripter.CaesarEnripter(step, userText);
            }
            if (criptType == "Vigener" & validator.KeywordNotNull(keyWord) &
                validator.ValidateUserMessage(userText))
            {
                result = cripterEncripter.VigenerEnripter(keyWord, userText);
            }
            return result;
        }
    }
}
