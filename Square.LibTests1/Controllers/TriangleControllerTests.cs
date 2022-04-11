using Microsoft.VisualStudio.TestTools.UnitTesting;
using Square.Lib.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square.Lib.Controllers.Tests
{
    [TestClass()]
    public class TriangleControllerTests
    {
        [TestMethod()]
        public void TriangleControllerTest()
        {
            //Arrange:
            Random rnd = new Random();
            double a = rnd.Next(10);
            double b = rnd.Next(10);
            double c = rnd.Next(10);
            //Act:
            TriangleController triangleController = new TriangleController(a, b, c);
            //Assert:
            Assert.IsFalse(triangleController.isRectangular());
        }


        [TestMethod()]
        public void SquareTest()
        {

            //Arrange:
            Random rnd = new Random();
            double a = rnd.Next(10);
            double b = rnd.Next(10);
            double c = rnd.Next(10);
            //Act:
            TriangleController triangleController = new TriangleController(a, b, c);
            var result = triangleController.Square();
            //Assert:
            Assert.AreEqual(triangleController.Square(), result);
        }
    }
}