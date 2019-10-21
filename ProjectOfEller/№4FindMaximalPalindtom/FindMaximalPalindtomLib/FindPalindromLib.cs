using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximalPalindtomLib
{
    public class FindPalindromLib
    {
        public int[] FindMaxPalindrom(int start,int finish)
        {
            int[] maxPalindrom = new int[3];
            maxPalindrom[0] = 0;
            for(int i = start; i < finish; i++)
            {
                for(int j = start; j < finish; j++)
                {
                    char[] pol = (i * j).ToString().ToCharArray();
                    Array.Reverse(pol);
                    if((i*j).ToString()==new string(pol))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Число палиндром {1}x{2}={0}",
                            i*j,i,j);
                        if (maxPalindrom[0] < i * j)
                        {
                            maxPalindrom[0] = i * j;
                            maxPalindrom[1] = i;
                            maxPalindrom[2] = j;
                        }
                    }
                }
            }
            return maxPalindrom;
        }
    }
}
