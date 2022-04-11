using Square.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square.Lib.Controllers
{
    /// <summary>
    /// Контроллер.
    /// </summary>
    public class CircleController
    {
        private Circle circle;
        public CircleController(double radius)
        {
            this.circle = new Circle(radius);
        }
        

        /// <summary>
        /// Площадь круга.
        /// </summary>
        /// <returns></returns>
        public double Square()
        {
            return Math.PI * Math.Pow(circle.Radius,2);
        }
        
    }
}
