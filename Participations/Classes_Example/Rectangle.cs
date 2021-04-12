using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example
{
    public class Rectangle
    {
        //public double GetLength()
        //{

        //    return _Length;
        //}

        //public void SetLength(double length)
        //{
        //    _Length = length;

        //}


        //if it should be read only dont put the set 
        public double Length { get; set; }
       


        private double Width { get; set; }

        /// <summary>
        /// Default/Empty constructor for this rectangle class
        /// Sets the values of the properties/attributes 
        /// </summary>
        public Rectangle()
        {
            Length = 7;
            Width = 7;
        }

        /// <summary>
        /// Overloaded constructor for the rectangle class 
        /// sets the properties to the passed in values
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        //cotr constructor, setting it up before you get access

        public Rectangle(double length, double width)
        {
            Length = Length;
            this.Width = Width;

        }
        /// <summary>
        /// Calculates the area of this rectangle instance 
        /// </summary>
        /// <returns>area of this rectangle</returns>

        public double CalculateArea()
        {
            return Width * Length;

        }

        /// <summary>
        /// Calculates the perimeter of this rectangle instance
        /// </summary>
        /// <returns>the perimeter of this rectangle </returns>
        public double CalculatePerimeter()
        {

            return 2 * (Length + Width);

        }



    }
}
