using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example
{
    public class Circle
    {
        public double Radius { get; set; }
        /// <summary>
        /// empty constructor that sets the starting value of the radius to 0
        /// </summary>
        public Circle()
        {
            Radius = 0;

        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);

        }

        /// <summary>
        /// calculates the perimeter of this circle
        /// </summary>
        /// <returns>the perimeter of this circle</returns>
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;


        }

    }

    
}
