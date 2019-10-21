using OperationsWithText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSimpleNum
{
    class ShowSum
    {
        static void Main(string[] args)
        {
            int limit = InputLimit();
            CalcSum calcSum = new CalcSum();
            ChangeTextColor("Green");
            ShowMessage("сумма этих чисел =" +
                calcSum.CalculateSum(limit).ToString());
            ChangeTextColor("White");
            Console.ReadKey();
        }
        private static int InputLimit()
        {
            Operations op = new Operations();
            try
            {
                ShowMessage("Введите предел для поиска" +
                    "простых чисел, например, 100");
                return int.Parse(Console.ReadLine());
            }
            catch {
                ChangeTextColor("Red");
                ShowMessage("Ошибка,введите число правильно.");
                ChangeTextColor("White");
                return InputLimit();
            }
        }
        public static void ChangeTextColor(string color)
        {
            switch (color)
            {
                case "White":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "Red":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
