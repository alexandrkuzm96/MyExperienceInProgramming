using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleDiviers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Простые делители числа 13195 - это 5, 7, 13 и 29.
             Каков самый большой делитель числа 600851475143, 
             являющийся простым числом?
             */
            int num =0;
            List<double> simpleNums = new List<double>();
            List<double> simpleDividers = new List<double>();
            simpleNums.Add(2);
            simpleNums.Add(3);
            string noDivided = "y";
            Console.WriteLine("Эьа программа находит все простые деители" +
                "введйного вами числа");
            InputNum(ref num);
            for(int i = 4; i < num; i++)
            {
                for(int j = 0; j < simpleNums.Count(); j++)
                {
                    if (i%simpleNums[j]!=0) { noDivided = "y"; }
                    else { noDivided = "n";
                        break;
                    }
                }
                if (noDivided == "y")
                {
                    simpleNums.Add(i);
                    Console.WriteLine("add {0}", i);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Массив простых чисел заполненг");
            Console.ForegroundColor = ConsoleColor.White;
            for(int i = 0; i < simpleNums.Count(); i++)
            {
                if (num % simpleNums[i] == 0)
                {
                    simpleDividers.Add(simpleNums[i]);
                    Console.WriteLine("Делится на {0}",simpleNums[i]);
                }
            }
            //Тоже самое но с помощю LINQ
            var dividers = from s in simpleNums
                        where num%s==0
                        select s;
            Console.Write("Простые делители этого чиса: ");
            foreach(var d in dividers)
            {
                Console.Write("{0}, ",d);
            }
        }
        private static void InputNum(ref int num)
        {
            try
            {
                Console.Write("Введите число ");
                num = int.Parse(Console.ReadLine());
            }
            catch(Exception ex) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message.ToString(), ex.Source.ToString() + "\n повтореите попытку");
                Console.ForegroundColor = ConsoleColor.White;
                InputNum(ref num);
            }
        }
    }
}
