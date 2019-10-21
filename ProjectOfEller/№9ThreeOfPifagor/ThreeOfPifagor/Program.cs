using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeOfPifagor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Тройка Пифагора - три натуральных числа a < b < c, для которых
             выполняется равенство a2 + b2 = c2
             Например, 32 + 42 = 9 + 16 = 25 = 52.
             Существует только одна тройка Пифагора,
             для которой a + b + c = 1000.
             Найдите произведение abc.
             */
            char finishSearch = 'n';
            int step = 100;
            int x = 0, y = 0, z = 0;
            for(int n=1; n < step; n++)
            {
                for(int m = n + 1; m < step; m++)
                {
                    x = m * m - n * n;
                    y = 2 * m * n;
                    z = m * m + n * n;
                    if (x + y + z == 1000)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0} {1} {2}",x,y,z);
                        finishSearch = 'y';
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0}, {1}, {2}", x, y, z);
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                step += 1;
                if (finishSearch == 'y') break;
            }

        }

    }
}
