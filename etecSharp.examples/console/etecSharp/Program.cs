using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace etecSharp
{
    class Examples
    { 
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            bool i = false;

            Console.Write(  "please select:\n"      +
                            "   a. circle area\n"   +
                            "   b. text stuff\n"    );
            
            while (!i) { //asks for input while "input" is null or invalid


                key = Console.ReadKey(); //prompts imput
                
                char input = key.KeyChar; //gets the character from "key", inserts into the char "input"

                switch (input) { //compares "input" with different options

                    case '1':
                        fun_1();
                        i = false;
                        break;

                    case '2':       //if '2' is pressed, execute function 2 [...]
                        fun_2();
                        i = false;
                        break;
                    
                    default:
                        Console.Write(" - invalid.\ninput:> "); //if the input is invalid, ask again
                        break;
                };
            };
        }

        static void fun_1()
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

        static void fun_2()
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

                "\n4.>\t\"" + txA + "\" == \""  + txB           + "\" = " + txA.Equals(txB) + //compare strings, check if they are equal

                "\n5.>\t\"" + txA+txB + "\" -> 6 characters -> \"" + (txA+txB).Substring(6,6)
            );
            
            Console.ReadKey(true);
        }
    }
}