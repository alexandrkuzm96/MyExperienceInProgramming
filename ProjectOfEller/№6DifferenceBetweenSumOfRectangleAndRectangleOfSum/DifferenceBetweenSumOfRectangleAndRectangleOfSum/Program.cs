using Dlegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenSumOfRectangleAndRectangleOfSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit= InputLimit();
            Calculate calc = new Calculate();
            int[]arr= calc.Calc(limit);
            ChaingeColor('G');
            Console.WriteLine($"Rect of sum={arr[1]} sum of rect={arr[0]} difference={arr[2]}");
            //вывод ответа с помощью делегата
            CalcDelegates calcDel = new CalcDelegates(limit);
            calcDel.RegisterDelegat(ShowMessage);
            calcDel.Calc(limit);
            ChaingeColor('W');
        }
        private static int InputLimit()
        {
            try
            {
                Console.WriteLine("Введите число");
                int limit = 0;
                limit = int.Parse(Console.ReadLine());
                return limit;
            }
            catch
            {
                ChaingeColor('R');
                Console.WriteLine("Ошибка введтье чтсло правильно.");
                ChaingeColor('W');
                return InputLimit();
            }
        }

        private static void ChaingeColor(char color)
        {
            switch (color)
            {
                case 'W':
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 'R':
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 'G':
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
        }

        private static void ShowMessage(String message)
        {
            Console.WriteLine(message);
        }
    }
}
