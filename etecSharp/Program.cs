using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace etecSharp
{
    class Circle
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("circle area calc.:\n");
            double radius = 0;
            
            if (args == null)
            {
                Console.Write("insert radius: ");
                radius = double.Parse(Console.ReadLine());
            } else {
                radius = Convert.ToDouble(args[1]);
            };
            
            Console.WriteLine("radius is " + radius + "\n");

            double cArea = (Math.PI * Math.Pow(radius, 2));
            Console.WriteLine("area is {0:N3} lol", cArea);

            Console.ReadKey(true);
        }
    }
}
