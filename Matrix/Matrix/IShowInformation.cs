
namespace Matrix
{
    public interface IShowInformation
    {
        void ShowMatrix(ref double[,] mas, ref double[,] mas2,ref int n);
        void ShowResult(ref double[,] resMass,ref int n);
        void ShowUI();
        void InputMatrixSize();
        void InputMatrix();
        void InputDegre();
    }
}
