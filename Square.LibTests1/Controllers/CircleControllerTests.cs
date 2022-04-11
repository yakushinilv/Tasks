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
    public class CircleControllerTests
    {
        [TestMethod()]
        public void CircleControllerTest()
        {
            //Arrange
            Random rnd = new Random();
            var radius = rnd.Next(100);
            //Action
            CircleController circleController = new CircleController(radius);
            var result = circleController.Square();
            //Assert
            Assert.AreEqual(circleController.Square(), result);
        }

       
    }
}