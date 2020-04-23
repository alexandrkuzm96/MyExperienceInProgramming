using System;

namespace FigureArea
{
    public class Circle : Figure
    {
        public override double CalculateArea(params double[] sides)
        {
            return Math.PI * Math.Pow(sides[0], 2);
        }
    }
}
