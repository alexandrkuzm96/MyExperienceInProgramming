
namespace MatrixOperationLib
{
    public class MatrixOpeerations:IMatrixOperation
    {
        public double[,] SumMatrix(
            ref double [,] mas,ref double[,]mas2, ref int n)
        {
            double[,] resultMatrix = new double[n,n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    resultMatrix[i, j] = mas[i, j] + mas2[i, j];
                }
            }
            return resultMatrix;
        }

        public double[,] SubtructionMatrix(
            ref double[,] mas,ref double[,]mas2,ref int n)
        {
            double[,] resultMass = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resultMass[i, j] = mas[i, j] - mas2[i, j];
                }
            }
            return resultMass;
        }

        public double [,] MultMatrix( double [,] mas,double[,] mas2, ref int n)
        {
            double[,] resMas = new double[n, n];
            for(int row = 0; row < n; row++)
            {
                for(int col=0; col < n; col++)
                {
                    for(int inner = 0; inner < n; inner++)
                    {
                        resMas[row, col] += mas[row, inner] * mas2[inner, col];
                    }
                }
            }
            return resMas;
        }

        public double[,] ExponentMatrix(double[,]resultMas, double [,] mas, int n,int p)
        {
            if (p == 1)
            {
                return resultMas;
            }
            else
            {

                resultMas = MultMatrix(resultMas,mas,ref n);
                return  ExponentMatrix(resultMas,mas,n,p-1);
            }
        }
    }
}
