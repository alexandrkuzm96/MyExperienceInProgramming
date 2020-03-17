using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptorEncriptor
{
    public interface ICripterEncripter
    {
        string VigenerCripter(string keyWord, string userText);
        string CaesarCripter(int step,string userText);
        string VigenerEnripter(string keyWord, string userText);
        string CaesarEnripter(int step, string userText);
    }
}
