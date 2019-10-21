using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixOperation
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветствует программа для осуществления арифметических операций" +
                    "гад матрицами размером n x n\n" +
                    "Для сложения матриц нажмите 1\nДля вычитания наужмите 2\n" +
                    "Для умножения 3\nДля возведения в степень 4");
                short operation = short.Parse(Console.ReadLine());
                Console.WriteLine("введите колл-во строк и столбцов");
                int n = int.Parse(Console.ReadLine());
                double[,] mas = new double[n, n];
                double[,] mas2 = new double[n, n];
                double[,] resultMass = new double[n, n];
                MatrixOperationLib.MatrixOpeerations matOper = new MatrixOperationLib.MatrixOpeerations();
                switch (operation) {
                    case 1:
                        Console.WriteLine("Введите матрицу 1");
                        mas = InputMas(n);
                        Console.WriteLine("Введите матрицу 2");
                        mas2 = InputMas(n);
                        ShowMatrix(ref n, ref mas, ref mas2);
                        Console.WriteLine("Сумма матриц");
                        resultMass= matOper.SumMatrix(mas, mas2, n);
                        ShowMatrix(resultMass, n);
                        break;
                    case 2:
                        Console.WriteLine("Введите матрицу 1");
                        mas = InputMas(n);
                        Console.WriteLine("Введите матрицу 2");
                        mas2 = InputMas(n);
                        ShowMatrix(ref n, ref mas, ref mas2);
                        matOper.SubtructionMatrix(ref resultMass, mas, mas2, n);
                        Console.WriteLine("Разница матриц");
                        ShowMatrix(resultMass, n);
                        break;
                    case 3:
                        Console.WriteLine("Введите матрицу 1");
                        mas = InputMas(n);
                        Console.WriteLine("Введите матрицу 2");
                        mas2 = InputMas(n);
                        ShowMatrix(ref n, ref mas, ref mas2);
                        resultMass= matOper.MultMatrix(n, mas, mas2);
                        Console.WriteLine("Произведение матриц");
                        ShowMatrix(resultMass, n);
                        break;
                    case 4:
                        Console.WriteLine("Введите матрицу");
                        mas = InputMas(n);
                        Console.WriteLine("Введите степень");
                        short power = short.Parse(Console.ReadLine());
                        for(int i=0; i < n; i++)
                        {
                            for(int j = 0; j < n; j++)
                            {
                                resultMass[i, j] = mas[i,j];
                            }
                        }
                        resultMass= matOper.ExponentMatrix(resultMass, mas, n, power);
                        ShowMatrix(resultMass, n);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Такой операции нет"); break;
                }         
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine(ex.Message.ToString(), ex.Source.ToString());
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadKey();
        }
        private static double[,] InputMas(int n)
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
        private static void ShowMatrix(ref int n,ref double[,]mas,ref double[,] mas2)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", mas[i, j].ToString());
                }
                Console.Write("\t");
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", mas2[i, j].ToString());
                }
                Console.WriteLine();
            }
        }

        private static void ShowMatrix(double [,] mas,int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", mas[i, j].ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
