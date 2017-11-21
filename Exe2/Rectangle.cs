using System;
using System.Collections.Generic;
using System.Text;

namespace Exe2
{
    class Rectangle : Shape
    {
        public override string GetInfo()
        {
            return $"name {name} with width{width} and height{height}";
        }

        private const string name = "Rectangle";
        protected readonly double width;
        protected readonly double height;

        public Rectangle(double w , double h)
        {
            width = w;
            height = h;
        }

        public double Width
        {
            get
            {
                return width;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
        }

        public virtual void GetArea()
        {
            double area = height * width;
        }


        
    }
}
