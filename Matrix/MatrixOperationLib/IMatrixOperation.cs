
namespace MatrixOperationLib
{
    public interface IMatrixOperation
    {
        double[,] SumMatrix(ref double[,] mas,ref double[,] mas2,ref int n);
        double[,] SubtructionMatrix(ref double[,] mas,ref double[,] mas2,ref int n);
        double[,] MultMatrix(double[,] mas,double[,] mas2, ref int n);
        double[,] ExponentMatrix(double[,] resultMas,double[,] mas, int n, int p);


    }
}
