using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public interface IInputValues
    {
        double[,] InputMas(int n);
        short MatrixSizeOrChoseOperation();
    }

    class Values : IInputValues
    {
        public double[,] InputMas(int n)
        {
                double[,] mas = new double[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mas[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }
                return mas;
        }

        public short MatrixSizeOrChoseOperation()
        {
            short matrixSize=0;
            try
            {
                matrixSize = short.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Source.ToString() + ex.Message.ToString());
                MatrixSizeOrChoseOperation();
            }
            return matrixSize;
        }
    }
}
