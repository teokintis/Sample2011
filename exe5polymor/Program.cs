using System;

namespace exe5polymor
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car { Brand = "Honda" };
            Car c2 = new Car { Brand = "BMW"};
            Console.WriteLine(c2.Equals(c1));
            Console.ReadKey();


        }
    }
}
