using System.Threading.Tasks;

namespace CriptorEncriptor
{
    public interface IButtonClick
    {
        string OpenFile();
        void SaveFile(string message);        
    }
}
