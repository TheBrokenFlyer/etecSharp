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
            char key=Convert.ToChar(Console.ReadKey());

            switch(key){
                case 'a':
                    fun_A();
                    break;
                case 'b':
                    fun_B();
                    break;
            }
        }

        static void fun_A()
        {
            Console.WriteLine("\n\ncircle area calc.:\n");
            double radius = 0;

           
            Console.Write("insert radius: ");
            radius = double.Parse(Console.ReadLine());
            

            Console.WriteLine("radius is " + radius + "\n");

            double cArea = (Math.PI * Math.Pow(radius, 2));
            Console.WriteLine("area is {0:N3} lol", cArea);

            Console.ReadKey(true);
        }

        static void fun_B()
        {
            Console.WriteLine("\n\nname var stuff.:\n");

            string txA,txB;

            Console.Write("\ninsert insert a name:                  >");
            txA = Console.ReadLine();
            Console.Write("\ninsert insert a batter name than that: >");
            txB = Console.ReadLine();

            Console.WriteLine(
                "\n0.>\t"   + txA + "\n\t"      + txB           +
                "\n1.>\t\"" + txA + "\" has "   + txA.Length    + " characters.\n\t\"" + txB + "\" has " + txB.Length + " characters." + "\n" +
            
                "\n2.>\t\"" + txA + "\" --> \"" + txA.ToUpper() + "\"" +            //convert to upper case lettering
                "\n3.>\t\"" + txA + "\" --> \"" + txA.ToLower() + "\"" + "\n" +     //convert to lower case lettering

                "\n4.>\t\"" + txA + "\" == \""  + txB           + "\" = " + txA.Equals(txB) //compare strings, check if they are equal
            );
            
            Console.ReadKey(true);
        }
    }
}
