using Square.Lib.Controllers;
using Square.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(4, 3, 5);
            Console.WriteLine(triangle.isRectangular);
            TriangleController triangleController = new TriangleController(7, 7, 7);
            CircleController circleController = new CircleController(10);
            Console.WriteLine(triangleController.Square());
            Console.WriteLine(circleController.Square());
            Console.ReadKey();
        }
    }
}
