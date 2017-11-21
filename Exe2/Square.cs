using System;
using System.Collections.Generic;
using System.Text;

namespace Exe2
{
    sealed class Square : Rectangle
    {
        private readonly string name = "Square";


        public Square(double w) : base(w, w)
        {
        }

        public override string GetInfo()
        {
            return $"name {name} with width{width} and height{height}";
        }


    }
}
