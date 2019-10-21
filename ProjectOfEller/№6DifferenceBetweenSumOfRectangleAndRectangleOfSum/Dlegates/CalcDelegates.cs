using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlegates
{
    public class CalcDelegates
    {
        public int limit;
        public delegate void CalculateDelegate(string result);
        CalculateDelegate calcDel;

        public CalcDelegates(int limit)
        {
            this.limit = limit;
        }
        public void RegisterDelegat(CalculateDelegate calcDel)
        {
            this.calcDel = calcDel;
        }
        public void Calc(int limit)
        {
            int sumOfRectangle = 0,
                rectangleOfSum = 0,
                difference = 0;
            int[] arr = new int[] { sumOfRectangle, rectangleOfSum, difference }; ;
            for (int i = 1; i <= limit; i++)
            {
                sumOfRectangle += (int)Math.Pow(i, 2);
                rectangleOfSum += i;
            }
            rectangleOfSum = (int)Math.Pow(rectangleOfSum, 2);
            difference = rectangleOfSum - sumOfRectangle;
            arr[0] = sumOfRectangle;
            arr[1] = rectangleOfSum;
            arr[2] = difference;
            if (calcDel != null)
                calcDel($"Квадрат суммы={rectangleOfSum} сумма квадратов={sumOfRectangle} разнсть={difference}"); ;
        }

    }
}
