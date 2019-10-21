using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumsOfFibanachi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Каждый следующий элемент ряда Фибоначчи 
             получается при сложении двух предыдущих. 
             Начиная с 1 и 2, первые 10 элементов будут:

             1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

             Найдите сумму всех четных элементов ряда Фибоначчи, 
             которые не превышают четыре миллиона.
             */
            int j = 0, sum = 0;
            List<int> numsOfFibanachi = new List<int>();
            Console.ForegroundColor = ConsoleColor.Blue;
            for(int i=0; i < 4000000; i++)
            {
                if (i == 0) { }
                if(i==1 | i == 2)
                {
                    numsOfFibanachi.Add(i);
                    j++;
                    Console.WriteLine("add {0}", i);
                }
                if(i!=0 & i!= 1 & i != 2)
                {
                    if (numsOfFibanachi[numsOfFibanachi.Count - 1] < 4000000) {
                        numsOfFibanachi.Add(numsOfFibanachi[j - 1] + numsOfFibanachi[j - 2]);
                        j++;
                        Console.WriteLine("add {0}", numsOfFibanachi[numsOfFibanachi.Count - 1]);
                    }
                    else { break; }                   
                }
            }
            var resultMass = from num in numsOfFibanachi
                             where num % 2 == 0
                             select num;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Числа фибоначи кратные 2");
            foreach (var n in resultMass)
            {
                Console.Write("{0}, ", n);
                sum += n;
            }
            Console.WriteLine("\n Сумма чётных чисел {0}", sum);
            Console.ReadKey();
        }
    }
}
