using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptorEncriptor
{
    class CripterEncripter : ICripterEncripter
    {
        private char[] alfavit = new char[] { 'A', 'a', 'B','b','C','c',
            'D', 'd','E','e','F','f','G','H','h','I','i','i','J','j',
            'K','k','L','l','M','m','N','n','O','o','P','p','Q','q',
            'R','r','S','s','T','t','U','u','V','v','W','w','X','x',
            'Y','y','Z','z','A','a','B','b','C','c','D','d','0','1',
            '2','3','4','5','6','7','8','9','А','а','Б','б','В','в',
            'Г','г','Д','д','Е','е','Ё','ё','Ж','ж','З','з','И','и',
            'Й','й','К','к','Л','л','М','м','Н','н','О','о','П','п',
            'Р','р','С','с','Т','т','У','у','Ф','ф','Х','х','Ц','ц',
            'Ч','ч','Ш','ш','ь','Щ','щ','ъ','Э','э','ы','Ю','ю','Я',
            'я',' ','.',',','?','!' };
        public string CaesarCripter(int step, string userText)
        {
            string criptedText=default(string);
            int c = 1;
            for (int i=0; i < userText.Length; i++)
            {
                c = (Array.IndexOf(alfavit, userText[i]) +
                    step) % alfavit.Length;
                criptedText += alfavit[c];
            }

            return criptedText;
        }

        public string CaesarEnripter(int step, string userText)
        {
            int p = 1;
            string encriptedText = default(string);
            for(int i=0; i<userText.Length; i++)
            {
                p = (Array.IndexOf(alfavit, userText[i])) % alfavit.Length;
            }
            return encriptedText;
        }

        public string VigenerCripter(string keyWord, string userText)
        {
            string criptedText = default(string);
            int N = alfavit.Length;
            int keyIndex = 0;
            foreach (char simbol in userText)
            {
                int c = (Array.IndexOf(alfavit, simbol) +
                        Array.IndexOf(alfavit, keyWord[keyIndex]))%N;
                    criptedText += alfavit[c];
                keyIndex = (keyIndex + 1 )== keyWord.Length ? 0 : keyIndex++;
            }
            return criptedText;
        }

        public string VigenerEnripter(string keyWord, string userText)
        {
            string encriptedText = default(string);
            int keyIndex = 0;
            int N = alfavit.Length;
            foreach(char simbol in userText)
            {
                int p = (Array.IndexOf(alfavit, simbol) + N -
                    Array.IndexOf(alfavit, keyWord[keyIndex]))%N;
                encriptedText += alfavit[p];
                keyIndex = (keyIndex + 1) == keyWord.Length ? 0 : keyIndex++;
            }
            return encriptedText;
        }
    }
}
