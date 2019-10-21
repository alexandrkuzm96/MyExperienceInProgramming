using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа ищет число, которое делится на все числа с 1 по  n");
            int num=0;
            Console.Write("Введите n");
            int n = int.Parse(Console.ReadLine());
            string divided = "y";
            for(int i = 1; i < i + 1; i++)
            {
                for (int j=1;j<=n;j++)
                {
                    if (i % j == 0)
                    {
                        divided = "y";
                    }
                    else
                    {
                        divided = "n";
                        break;
                    }
                }
                if (divided == "y")
                {
                    num = i;
                    break;
                }
            }
            Console.WriteLine("num={0}", num);
        }
    }
}
