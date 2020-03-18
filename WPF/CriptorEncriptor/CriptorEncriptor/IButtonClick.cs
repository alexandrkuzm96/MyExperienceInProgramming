using System.Threading.Tasks;

namespace CriptorEncriptor
{
    public interface IButtonClick
    {
        Task<string> OpenFile();
        void SaveFile(string message);        
    }
}
