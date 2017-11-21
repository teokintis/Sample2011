using System;
using System.Collections.Generic;
using System.Text;

namespace Exe2
{
    abstract class Shape
    {
        protected string color;
        public string ColorShape
        {
          
            get
            {
                return ColorShape;

            }

        }

        public void SetColor(string color1)
        {
            color = color1;
        }


        public abstract string GetInfo();
        
    }
}
