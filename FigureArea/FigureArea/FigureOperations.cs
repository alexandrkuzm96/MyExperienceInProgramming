using System.Linq;

namespace FigureArea
{
    public  class FigureOperations
    {
        public string CalculateArea(params double[]sides) {
            Figure f;
            string result = "";
            switch(sides.Count()){
                case 1:
                    f = new Circle();
                    result= "Площадь круга="+f.CalculateArea(sides);
                    break;
                case 3:
                    Triangle tr = new Triangle();
                    result = "Площадь треугольника=" + tr.CalculateArea(sides) +
                        " " + tr.TreangleType(sides);
                    break;
                default:
                    result = "Не удатся посчитать площадь данной фигкры.";
                    break;
            }
            return result;
        }
    }
}
