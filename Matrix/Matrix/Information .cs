using System;

namespace Matrix
{
    class Information : IShowInformation
    {
        public void InputDegre()
        {
            Console.WriteLine("Введите степень.");
        }

        public void InputMatrix()
        {
            Console.WriteLine("Заполните матрицу.");
        }

        public void InputMatrixSize()
        {
            Console.WriteLine("введите колл-во строк и столбцов");
        }

        public void ShowMatrix(ref double[,] mas, ref double[,] mas2,ref int n)
        {
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j <n; j++)
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
        public void ShowResult(ref double[,] resMass,ref int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", resMass[i, j].ToString());
                }
                Console.WriteLine();
            }
        }
        public void ShowUI()
        {
            Console.WriteLine("Вас приветствует программа для осуществления арифметических операций" +
                        "над матрицами размером n x n\n" +
                        "Для сложения матриц нажмите 1\nДля вычитания наужмите 2\n" +
                        "Для умножения 3\nДля возведения в степень 4\n" +
                        "для выхода нажмите  0");
        }
    }
}
