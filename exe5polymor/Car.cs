using System;
using System.Collections.Generic;
using System.Text;

namespace exe5polymor
{
    class Car : IEquatable<Car>
    {   
        public string Brand { get; set; }
        

        public bool Equals(Car other)
        {
            if (Brand == other.Brand)
            {
                return true;
            }
            return false;
        }
    }


}
