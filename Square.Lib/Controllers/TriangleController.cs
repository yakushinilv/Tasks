using Square.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square.Lib.Controllers
{
    public class TriangleController
    {
        private Triangle triangle;
        /// <summary>
        /// Конструктор контроллера Triangle.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public TriangleController(double a, double b, double c)
        {
            this.triangle = new Triangle(a, b, c);
        }
        public TriangleController(Triangle triangle)
        {
            this.triangle = triangle;
        }
        /// <summary>
        /// Вычисление полупериметра.
        /// </summary>
        /// <returns></returns>
        private double half_perimetr()
        {
            return (triangle.a + triangle.b + triangle.c) / 2;
        }
        public bool isRectangular()
        {
            return this.triangle.isRectangular;
        }
      
        /// <summary>
        /// Площадь треугольника.
        /// </summary>
        /// <returns></returns>
        public double Square()
        {
            double p = half_perimetr();
            double expression = (p * (p - triangle.a) * (p - triangle.b) * (p - triangle.c));
            return Math.Sqrt(expression);
        }

    }
}
