using System.Windows.Input;

namespace CriptorEncriptor
{
    public interface IValidator
    {
        void ValidateKey(KeyEventArgs e);
        bool KeywordNotNull(string s);
        bool StepNoNull(string s);
        bool ValidateUserMessage(string s);
    }
}
