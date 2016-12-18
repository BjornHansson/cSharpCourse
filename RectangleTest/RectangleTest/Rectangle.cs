using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleTest
{
    class Rectangle
    {
        private double length;

        public double Length
        {
            get { return length; }
            set { if (verfiy(value)) length = value; }
        }

        private double width;

        public double Width
        {
            get { return width; }
            set { if (verfiy(value)) width = value; }
        }

        private bool verfiy(double value)
        {
            if (value > 0.0 && value < 20.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public double getArea()
        {
            return length * width;
        }

        public double getPerimeter()
        {
            return (length + length + width + width);
        }
    }
}
