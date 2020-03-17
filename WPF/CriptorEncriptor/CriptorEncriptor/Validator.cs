using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CriptorEncriptor
{
    class Validator : IValidator
    {
        public bool KeywordNotNull(string s)
        {
            bool result = false;
            if (string.IsNullOrEmpty(s))
            {
                MessageBox.Show("Ввеите ключевое слово.");
            }
            else { result = true; }
            return result;
        }

        public bool StepNoNull(string s)
        {
            bool result = false;
            if (string.IsNullOrEmpty(s))
            {
                MessageBox.Show("Ввеите шаг.");
            }
            else { result = true; }
            return result;
        }

        public void ValidateKey(KeyEventArgs e)
        {
            if (e.Key != Key.D0 & e.Key != Key.D1 & e.Key != Key.D2 &
                e.Key != Key.D3 & e.Key != Key.D4 & e.Key != Key.D5 &
                e.Key != Key.D6 & e.Key != Key.D7 & e.Key != Key.D8 &
                e.Key != Key.D9)
            {
                e.Handled = true;
                MessageBox.Show("Вводить иожно только цифры");
            }
            else
            {
                e.Handled = false;
            }
        }

        public bool ValidateUserMessage(string s)
        {
            bool result = false;
            if (string.IsNullOrEmpty(s))
            {
                MessageBox.Show("Ввеите текст для шифрования или расшифрования.");
            }
            else { result = true; }
            return result;
        }
    }
}
