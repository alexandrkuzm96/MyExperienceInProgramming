using System;
using System.Linq;

namespace FigureArea
{
    public class Triangle : Figure,ITriangleType
    {

        public override double CalculateArea(params double[]sides)
        {
            double p = sides.Sum() / 2;
            double s= Math.Sqrt(p*(p-sides[0])*(p-sides[1])*(p-sides[2]));
            return s;
        }

        public string TreangleType(params double[] sides)
        {
            if (
                sides[0] == Math.Sqrt(Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2)) |
                sides[1] == Math.Sqrt(Math.Pow(sides[0], 2) + Math.Pow(sides[2], 2)) |
                sides[2] == Math.Sqrt(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)))
            {
                return "Этот треугольник прямоугольный";
            }
            else return "Этот треугольник непрямоугольный";
        }
    }
}
