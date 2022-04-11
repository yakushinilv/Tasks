using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square.Lib.Models
{
   public class Triangle
    {
       public double a { get; }
       public double b { get; }
       public double c { get; }

        /// <summary>
        /// Является ли треугольник равнобедренным.
        /// </summary>
       public bool isRectangular { get { return (a == Math.Sqrt(b * b + c * c) || b == Math.Sqrt(a * a + c * c) || c == Math.Sqrt(b * b + a * a)); } }
      
        /// <summary>
        /// Конструктор класса Triangle.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle (double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
}
