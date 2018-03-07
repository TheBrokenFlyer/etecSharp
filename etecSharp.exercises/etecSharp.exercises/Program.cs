using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1 {

    class Exercises_1 {

        static void Main(string[] args) {

            ConsoleKeyInfo key;
            bool i=true;

            Console.Write(  "pls enjoy program:\n" +
                            "   1. read and confirm\n" +
                            "   2. double\n" +
                            "   3. square²\n" +
                            "   4. A² + 5 - C / (B - A % 4)\n" +
                            "   5. isAboveEighteen\n" +
                            "   6. convert to US Dollars\n" +
                            "\n" +
                            "input:> ");

            while (i) { //asks for input while "input" is null or invalid


                key = Console.ReadKey(); //prompts imput
                
                char input = key.KeyChar; //gets the character from "key", inserts into the char "input"

                switch (input) { //compares "input" with different options
                    case '1':
                        ex1();
                        i = false;
                        break;
                    case '2':       //if '2' is pressed, execute function 2 [...]
                        ex2();
                        i = false;
                        break;
                    case '3':
                        ex3();
                        i = false;
                        break;
                    case '4':
                        ex4();
                        i = false;
                        break;
                    case '5':
                        ex5();
                        i = false;
                        break;
                    case '6':
                        ex6();
                        i = false;
                        break;
                    default:
                        Console.Write(" - invalid.\ninput:> "); //if the input is invalid, ask again
                        break;
                };
            };

            //end
            Console.ReadKey(true);
        }

        static void ex1() {
            Console.Write("\n\n\tinsert name:\t");
            string name = Console.ReadLine();
            Console.Write("\tinsert england:\t");
            string city = Console.ReadLine();
            Console.Write("\tinsert age:\t");
            string age = Console.ReadLine(); //string because i am lazy to fix compiler errors to convert stuff .-.

            Console.WriteLine(
                "\n\tname:  {0}" +
                "\n\tcity:  {1}" +
                "\n\tage:   {2}",
                name, city, age
            );
        }

        static void ex2() {
            Console.Write("\ninsert a number:   ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + x + " * 2 = " + x * 2);
            Console.ReadKey(true);
        }

        static void ex3() {
            Console.Write("\n\n\tinsert a number:   ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\t" + x + " * 2 = " + Math.Pow(x,2));
            Console.ReadKey(true);
        }

        static void ex4() {
            Console.Write("\n\n\tinsert A:  ");
            double A = int.Parse(Console.ReadLine());
            Console.Write("\tinsert B:  ");
            double B = int.Parse(Console.ReadLine());
            Console.Write("\tinsert C:  ");
            double C = int.Parse(Console.ReadLine());

            double res = Math.Pow(A, 2) + 5 - C / (B - A % 4);
            Console.Write("\n\tthe result is {0:N2}", res);
        }

        static void ex5() {
            Console.Write("\n\n\tinsert an age:     ");
            int x = int.Parse(Console.ReadLine());
            if (x < 18)
            {
                Console.WriteLine("\tless than 18.");
            }
            else
            {
                Console.WriteLine("\tequals or more than 18.");
            }
        }

        static void ex6() {
            Console.Write("\n\n\tinsert a R$:       ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("\tR$ {0:N2} --> US$ {1:N2}", x, x/3.25);
        }
    }
}
