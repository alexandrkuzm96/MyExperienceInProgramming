using System.Linq;

namespace MultiplicationOf13Nums
{
    class Calculate
    {
        public int[] Calc(int count,string num)
        {
            int[] results = new int[count + 1];
            int max = 0, result = 1;
            for(int i = 0; i < num.Length - (count - 1); i++)
            {
                for(int j = i; j < i + count; j++)
                {
                    result *= int.Parse(num[j].ToString());
                }
                if( max < result)
                {
                    for(int j = 0; j < results.Count() - 1; j++)
                    {
                        results[j] = int.Parse(num[i + j].ToString());
                    }
                    max = result;
                    results[count] = max;
                }
                result = 1;
            }
            return results;
        }
    }
}
