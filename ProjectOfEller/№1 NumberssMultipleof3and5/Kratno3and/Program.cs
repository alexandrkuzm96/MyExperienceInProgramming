using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberssMultipleof3and5
{
    class Program
    {
        /*
         Если выписать все натуральные числа меньше 10,
         кратные 3 или 5, то получим 3, 5, 6 и 9. 
         Сумма этих чисел равна 23.

         Найдите сумму всех чисел меньше 1000, кратных 3 или 5.*/
        delegate int CalculateValue(int val);
        delegate int InputValue();
        static void Main(string[] args)
        {
            FindMultiple find = new FindMultiple();
            InputValue input = InputLimit;
            int limit =input();
            CalculateValue calc = find.FindSumMultipleOf3and5;
            int max = calc(limit);
            Console.Write("Сумма чисел кратных 3 и 5" +
                "меньше {1} равна {0}", max, limit);
            Console.ReadKey();
        }
        static int InputLimit()
        {
            int limit = 0;
            try
            {
                limit = int.Parse(Console.ReadLine());
            }
            catch {
                InputLimit();
            }
            return limit;
        }
    }
}
