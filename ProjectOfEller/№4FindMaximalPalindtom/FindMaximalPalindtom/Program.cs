using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximalPalindtom
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowPalindroms();
        }
        private static void ShowPalindroms()
        {
            try
            {
                int start = 0, finish = 0;
                Console.WriteLine("Введите диапазон для поиска чисел " +
                    "палиндромов через запятую, например 10, 100");
                string str = Convert.ToString(Console.ReadLine());
                string[] numbers = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                start = int.Parse(numbers[0]);
                finish = int.Parse(numbers[1]);
                FindMaximalPalindtomLib.FindPalindromLib find = new
                  FindMaximalPalindtomLib.FindPalindromLib();
                int[] max = find.FindMaxPalindrom(start, finish);
                Console.WriteLine("Самый большой палиндром полученный" +
                    "при умножении 2 трехзначных чисел {1}x{2}={0}", max[0], max[1], max[2]);
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message.ToString(), ex.Source.ToString() +
                    " повторите попытку");
                Console.ForegroundColor = ConsoleColor.White;
                ShowPalindroms();
            }
        }
    }
}
