using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    //Class
    internal class Circle
    {
        private double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCurcumference()
        {
            return 2 * Math.PI * Radius;
        }
    }

    //Methods
    
}


