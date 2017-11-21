using System;
using System.Collections.Generic;

namespace exe1polymorh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Shapes = new List<Shape>
            {
                new Shape(),
                new Rectangle(),
                new Circle(),
                new Triangle()
            };

            foreach (var item in Shapes)
            {
                item.Draw();
            }


            Console.ReadKey();
        }
    }
}
