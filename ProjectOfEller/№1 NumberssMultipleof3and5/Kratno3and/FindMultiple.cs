using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberssMultipleof3and5
{
    class FindMultiple
    {
        public int FindSumMultipleOf3and5(int limit)
        {
            int[] arr = new int[limit];
            for(int i = 0; i < limit; i++)
            {
                arr[i] = i;
            }
            int sum = (from s in arr
                       where s % 3 == 0 | s % 5 == 0
                       select s).Sum(); 
            return sum;
        }
    }
}
