using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001SimpleNum
{
    class SeatchMaxSimpleNum
    {
        public int FindNum(int limit)
        {
            List<int> simpleNums = new List<int> { 2 };
            string d = "Y";
            for (int i = 2; i < limit; i++)
            {
                for(int j = 0; j < simpleNums.Count; j++)
                {
                    if (i % simpleNums[j] == 0) { 
                        d= "Y";
                        break;
                    }
                    else d = "N";
                }
                if (d == "N")
                {
                    simpleNums.Add(i);
                    Console.Write("{0}, ", i);
                }
            }
            Console.WriteLine();
            int max = simpleNums.Max();
            return max;
        }
    }
}
