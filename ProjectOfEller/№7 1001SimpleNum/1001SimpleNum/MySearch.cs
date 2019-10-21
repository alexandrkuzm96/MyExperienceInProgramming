using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001SimpleNum
{
    class MySearch
    {
        static void Main(string[] args)
        {
            /*Выписав первые шесть простых чисел, получим 
             * 2, 3, 5, 7, 11 и 13.
             * Очевидно, что 6-ое простое число - 13.
            Какое число является 10001-ым простым числом?*/
            ShowMessage("Выписав первые шесть простых чисел, получим"+ 
               "2, 3, 5, 7, 11 и 13."+
               "Очевидно, что 6 - ое простое число - 13."+
           " Какое число является 10001 - ым простым числом ? ");
            int limit = InputValue();
            SeatchMaxSimpleNum search = new SeatchMaxSimpleNum();
            int max = search.FindNum(limit);
            ChangeColor("Green");
            ShowMessage($"Максимальное простое число в пределах " +
                $"{limit} это {max}");
        }
        private static int InputValue()
        {
            try
            {
                int limit = 0;
                ShowMessage("Введите число, в пределах которого" +
                    "проводить поиск простого числа, например, 10001");
                limit = int.Parse(Console.ReadLine());
                return limit;
            }
            catch
            {
                ChangeColor("Red");
                ShowMessage("Ошибка, введите число правильно");
                ChangeColor("White");
                return InputValue();
            }
        }
        private static void ChangeColor(string color)
        {
            switch (color)
            {
                case "White":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
        }
        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
