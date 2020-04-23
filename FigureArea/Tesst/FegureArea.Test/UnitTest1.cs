using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureArea;
namespace FegureArea.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateTriangleAreaTest1()
        {
            Triangle tr = new FigureArea.Triangle();            
            double expectedResult = Math.Sqrt(63);
            double result = tr.CalculateArea(4,4,6);
            Assert.AreEqual(expectedResult , result);
        }
        [TestMethod]
        public void TriangleTypeTest()
        {
            Triangle tr = new Triangle();
            string expectedResult= "Этот треугольник непрямоугольный";
            string result = tr.TreangleType(4, 4, 6 );
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void CircleAreaTest() {
            Circle ci = new Circle();
            double expectedResult = Math.PI* 16;
            double result = ci.CalculateArea(4);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void FigureOperationTest() {
            string expectedResult = "Не удатся посчитать площадь данной фигкры.";
            FigureOperations f = new FigureOperations();
            string result = f.CalculateArea(1, 2);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
