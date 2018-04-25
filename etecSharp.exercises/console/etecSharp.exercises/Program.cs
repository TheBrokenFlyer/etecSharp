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
                            "   7. classes and stuff\n" + 
                            "   8. classes and methods 2\n" +
                            "   9. another one\n" +
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
                    case '7':
                        ex7();
                        i = false;
                        break;
                    case '8':
                        ex8();
                        i = false;
                        break;
                    case '9':
                        ex9();
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

        //read and write
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

        //double the number
        static void ex2() {
            Console.Write("\ninsert a number:   ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + x + " * 2 = " + x * 2);
            Console.ReadKey(true);
        }

        //square number
        static void ex3() {
            Console.Write("\n\n\tinsert a number:   ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("\n\t" + x + " * " + x + " = " + Math.Pow(x,2));
            Console.ReadKey(true);
        }

        //some equation stuff
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

        //check if >18
        static void ex5() {
            Console.Write("\n\n\tinsert an age:     ");
            int x = int.Parse(Console.ReadLine());
            if (x < 18) {
                Console.WriteLine("\tless than 18.");
            } else {
                Console.WriteLine("\tequals or more than 18.");
            }
        }

        //conversion of dollars
        static void ex6() {
            Console.Write("\n\n\tinsert a R$:       ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("\tR$ {0:N2} --> US$ {1:N2}", x, x / 3.25);
        }


        //Classes and methods
        static void ex7() {
            Console.Write("\n\n\t");

            HerancasPessoas.Pessoa person1      = new HerancasPessoas.Pessoa();
            HerancasPessoas.Aluno person2       = new HerancasPessoas.Aluno();
            HerancasPessoas.Funcionario person3 = new HerancasPessoas.Funcionario();
            HerancasPessoas.Professor person4   = new HerancasPessoas.Professor();

            person1.setAge(19);
            person1.setGender('F');
            person1.setName("Someone");

            Console.Write(  "person1.age:     {0}\n\t" +
                            "person1.gender:  {1}\n\t" +
                            "person1.name:    {2}\n\t" ,
                            person1.getAge(),
                            person1.getGender(),
                            person1.getName());

        }

        //Classes and methods 2
        static void ex8() {
            Console.Write("\n\n\t");

            HerancasAnimais.Animal  animal1 = new HerancasAnimais.Animal();
            HerancasAnimais.Mammal  animal2 = new HerancasAnimais.Mammal();
            HerancasAnimais.Bird    animal3 = new HerancasAnimais.Bird();
            HerancasAnimais.Reptile animal4 = new HerancasAnimais.Reptile();

            animal1.setAge(5);
            animal1.setMembers(8);
            animal1.setWeight(5.500f);

            animal2.setAge(14);
            animal2.setMembers(4);
            animal2.setWeight(25.500f);
            animal2.setFurColor("white");

            Console.Write(  "animal1.age:     {0}\n\t" +
                            "animal1.members: {1}\n\t" +
                            "animal1.weight:  {2}\n\t" +
                            "\n\n" ,
                            animal1.getAge(),
                            animal1.getMembers(),
                            animal1.getWeight());
            
            animal1.move();
            animal1.eat();
            animal1.emitSound();

            Console.Write("\n\n\n\t");
            Console.Write(  "animal2.age:     {0}\n\t" +
                            "animal2.members: {1}\n\t" +
                            "animal2.weight:  {2}\n\t" +
                            "animal2.furColor:{3}\n\t" +
                            "\n\n",
                            animal2.getAge(),
                            animal2.getMembers(),
                            animal2.getWeight(),
                            animal2.getFurColor());

            animal2.move();
            animal2.eat();
            animal2.emitSound();

            //[...]
        }

        //Another one.
        static void ex9() {
            Console.Write("\n\n\t");

            HerancasEmpregados.Empregado empregado1     = new HerancasEmpregados.Empregado();
            HerancasEmpregados.Assalariado empregado2   = new HerancasEmpregados.Assalariado();
            HerancasEmpregados.Commissionado empregado3 = new HerancasEmpregados.Commissionado();
            HerancasEmpregados.Horista empregado4       = new HerancasEmpregados.Horista();

            empregado1.setName("dummyOne");
            empregado1.setLastName("dummiski");
            empregado1.setDocument(1233211233);

            Console.Write("\n\t");
            Console.Write(  "empregado1.nome:       {0}\n\t" +
                            "empregado1.sobrenome:  {1}\n\t" +
                            "empregado1.documento:  {2}\n\t" +
                            "\n\n",
                            empregado1.getName(),
                            empregado1.getLastName(),
                            empregado1.getDocument()
                            );

            empregado1.vencimento();


            empregado2.setName("dummyToo");
            empregado2.setLastName("asdfa");
            empregado2.setDocument(321654894);
            empregado2.setSalario(300);

            Console.Write("\n\t");
            Console.Write(  "empregado2.nome:       {0}\n\t" +
                            "empregado2.sobrenome:  {1}\n\t" +
                            "empregado2.documento:  {2}\n\t" +
                            "empregado2.salario:    {2}\n\t",
                            empregado2.getName(),
                            empregado2.getLastName(),
                            empregado2.getDocument(),
                            empregado2.getSalario()
                            );

            empregado2.vencimento();
            empregado2.vencimento();
            empregado2.vencimento();


            empregado3.setName("dummyTeww");
            empregado3.setLastName("fdsafdsafdsafdsafdsafdsafdsafdsafdsafdsa");
            empregado3.setDocument(654656544);
            empregado3.setTotalVenda(998900);
            empregado3.setTaxaComissao(10);

            Console.Write("\n\n\n\t");
            Console.Write(  "empregado3.nome:           {0}\n\t" +
                            "empregado3.sobrenome:      {1}\n\t" +
                            "empregado3.documento:      {2}\n\t" +
                            "empregado3.totalVenda:     {3}\n\t" +
                            "empregado3.taxaComissao:   {4}\n\t" +
                            "\n\n",
                            empregado3.getName(),
                            empregado3.getLastName(),
                            empregado3.getDocument(),
                            empregado3.getTotalVenda(),
                            empregado3.getTaxaComissao()
                            );

            empregado3.vencimento();


            empregado4.setName("dummyFour");
            empregado4.setLastName("EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
            empregado4.setDocument(444444444);
            empregado4.setPrecoHora(12);
            empregado4.setHorasTrabalhadas(3595);

            Console.Write("\n\t");
            Console.Write(  "empregado4.nome:               {0}\n\t" +
                            "empregado4.sobrenome:          {1}\n\t" +
                            "empregado4.documento:          {2}\n\t" +
                            "empregado4.precoHora:          {3}\n\t" +
                            "empregado4.horasTrabalhadas:   {4}\n\t",
                            empregado4.getName(),
                            empregado4.getLastName(),
                            empregado4.getDocument(),
                            empregado4.getPrecoHora(),
                            empregado4.getHorasTrabalhadas()
                            );

        }
    }
}
