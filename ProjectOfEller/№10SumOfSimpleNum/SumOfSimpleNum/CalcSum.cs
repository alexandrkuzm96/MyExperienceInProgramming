using OperationsWithText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSimpleNum
{
    class CalcSum
    {
        public int CalculateSum(int limit)
        {
            List<int> simpleNums = new List<int> { 2 };
            char d = 'Y';
            for (int i = 3; i < limit; i++)
            {
                for (int j = 0; j < simpleNums.Count; j++)
                {
                    if (i % simpleNums[j] == 0)
                    {
                        d = 'Y';
                        break;
                    }
                    else d = 'N';
                }
                if (d == 'N')
                {
                    simpleNums.Add(i);
                }
            }
            return simpleNums.Sum();
        }
    }
}
