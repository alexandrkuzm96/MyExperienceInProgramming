using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperationLib
{
    public class MatrixOpeerations
    {
        public double[,] SumMatrix( double [,] mas,double[,]mas2,int n)
        {

            double [,] resultMatrix = new double[n, n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    resultMatrix[i, j] = mas[i, j] + mas2[i, j];
                }
            }
            return resultMatrix;
        }

        public void SubtructionMatrix(ref double[,] resultMas, double[,] mas,double[,]mas2,int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resultMas[i, j] = mas[i, j] - mas2[i, j];
                }
            }
        }

        public double [,] MultMatrix(int n,double [,] mas,double[,] mas2)
        {
            double[,] resultMas = new double[n, n];
            for(int row = 0; row < n; row++)
            {
                for(int col=0; col < n; col++)
                {
                    for(int inner = 0; inner < n; inner++)
                    {
                        resultMas[row, col] += mas[row, inner] * mas2[inner, col];
                    }
                }
            }
            return resultMas;

        }

        public double[,] ExponentMatrix(double[,]resultMas,double [,] mas,int n,int p)
        {
            if (p == 1)
            {
                return resultMas;
            }
            else
            {

                resultMas = MultMatrix(n, resultMas, mas);
                return  ExponentMatrix(resultMas,mas,n,p-1);
            }
        }
    }
}
