using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * ----------PEOPLE----------
 */
namespace HerancasPessoas {

    class Pessoa {
        private string  name = null;
        private int age = -1;
        private int gender = -1;

        /* GET */
        public string getName() {
            return this.name;
        }

        public int getAge() {
            return this.age;
        }

        public char getGender() {
            if (gender == 1) {
                return 'M';
            } else if (gender == 2) {
                return 'F';
            } else {
                return '-';
            }
        }


        /* SET */
        public string setName(string args) {
            return this.name=args;
        }

        public int setAge(int args) {
            return this.age=args;
        }

        public int setGender(char args) {
            if (args == 'M') {
                
                return gender=1;

            } else if (args == 'F') {
                
                return gender=2;
            
            } else {

                return gender=-1;
            
            }
        }

        public void anniversary() {
            this.age++;
        }
    }


    class Aluno:Pessoa {
        private int     registry = 000000;
        private string  course = null;

        /* GET */
        public int getRegistry() {
            return this.registry;
        }

        public string setCourse() {
            return this.course;
        }


        /* SET */
        public int setRegistry(int args) {
            return this.registry = args;
        }

        public string setCourse(string args) {
            return this.course = args;
        }
    }


    class Funcionario:Pessoa {
        private string  sector = null;
        private bool    isWorking = false;

        /* GET */
        public string getSector() {
            return this.sector;
        }

        public bool getIsWorking() {
            return this.isWorking;
        }


        /* SET */
        public string setSector(string args) {
            return this.sector=args;
        }

        public bool setIsWorking(bool args) {
            return this.isWorking=args;
        }
    };


    class Professor:Pessoa {
        private string  specialty = null;
        private float   salary = 0.00f;

        /* GET */
        public string getSpecialty() {
            return this.specialty;
        }

        public float getSalary() {
            return this.salary;
        }


        /* SET */
        public string setSpecialty(string args) {
            return this.specialty = args;
        }

        public float setSalary(float args) {
            return this.salary = args;
        }
    }

}


/* 
 * ----------ANIMALS----------
 */
namespace HerancasAnimais {
    class Animal {
        private float weight = .00f;
        private int age      = 0,
                    members  = 4;

        /* GET */
        public virtual void move() {
            Console.WriteLine("\tit moved.");
        }

        public void eat() {
            Console.WriteLine("\tyou haven't writen classes for food yet, you dummy.");
        }

        public void emitSound() {
            Console.Beep(2000, 500);
            Console.WriteLine("\tit made a sound.");
        }

        public float getWeight() {
            return this.weight;
        }

        public int getAge() {
            return this.age;
        }

        public int getMembers() {
            return this.members;
        }


        /* SET */
        public float setWeight(float args) {
            return this.weight = args;
        }

        public int setAge(int args) {
            return this.age = args;
        }

        public int setMembers(int args) {
            return this.members = args;
        }
    }

    class Mammal:Animal {
        private string furColor = null;

        public string setFurColor(string args) {
            return this.furColor = args;
        }

        public string getFurColor() {
            return this.furColor;
        }
    }

    class Kangaroo:Mammal {
        public override void move() { }
        public void useBag() { }
    }

    class Dog:Mammal {
        public void burryBone() { }
        public void wagTail() { }
        public void gowl() { }
        public void bark() { }
        public void play() { }
        
        
         //multiple methods can have the same name,
        //but they must have a different set of parameters and/or return types.
        public void react(string attitude)  {

	        if (attitude.Equals("play") | attitude.Equals("pet")) {
                wagTail();
	        } else {
                gowl();
            }

        }

	    public void react(int hour, int min){

	        if (hour < 12) {
                wagTail();
                bark();

	        } else if(hour >= 18) {
		        //ignore

            } else {
                wagTail();

            }

        }
        
	    public void react(bool owner){
            
            if (owner) {
                wagTail();
                play();

            } else {
                gowl();

            }

        }
    }

    class Reptile:Animal {
        private string scalesColor = null;

        public string setScalesColor(string args) {
            return this.scalesColor = args;
        }

        public string getScalesColor(string args) {
            return this.scalesColor;
        }
    }

    class Turtle:Reptile {
        public override void move() { }
    }

    class Bird:Animal {
        private string featherColor = null;

        /* SET */
        public string setFeatherColor(string args) {
            return this.featherColor = args;
        }

        public void makeShelter() {
            Console.WriteLine("\tthe bird is making it's shelter");
        }

        /* GET */
        public string getScalesColor(string args) {
            return this.featherColor;
        }
    }

    class Tucan:Bird { }
}

/*
 * ----------EMPLOYEES----------
 */
namespace HerancasEmpregados {
    class Empregado {
        private string  name = null,
                        lastName = null;
        private int     document = 0;

        public virtual double vencimento() { return 0; }

        /* GET */
        public string getName() {
            return this.name;
        }

        public string getLastName() {
            return this.lastName;
        }

        public int getDocument() {
            return this.document;
        }

        /* SET */
        public string setName(string args) {
            return this.name = args;
        }

        public string setLastName(string args) {
            return this.lastName = args;
        }

        public int setDocument(int args) {
            return this.document = args;
        }
    }

    class Assalariado : Empregado {
        private double salario = 0;
        
        public override double vencimento() {
            Console.WriteLine("\n\t" + this + " recebeu 300.\n\tatual: " + getSalario());
            return this.salario+=300;
        }

        /* GET */
        public double getSalario() {
            return this.salario;
        }

        /* SET */
        public double setSalario(double args) {
            return this.salario = args;
        }
    }

    class Commissionado : Empregado {
        private double  totalVenda = 0,
                        taxaComissao = 0;

        public override double vencimento() { return 0; }

        /* GET */
        public double getTotalVenda() {
            return this.totalVenda;
        }

        public double getTaxaComissao() {
            return this.taxaComissao;
        }

        /* SET */
        public double setTotalVenda(double args) {
            return this.totalVenda = args;
        }

        public double setTaxaComissao(double args) {
            return this.taxaComissao = args;
        }
    }

    class Horista : Empregado {
        private double  precoHora = 0,
                        horasTrabalhadas = 0;

        public override double vencimento() { return 0; }

        /* GET */
        public double getPrecoHora() {
            return this.precoHora;
        }

        public double getHorasTrabalhadas() {
            return this.horasTrabalhadas;
        }

        /* SET */
        public double setPrecoHora(double args) {
            return this.precoHora = args;
        }

        public double setHorasTrabalhadas(double args) {
            return this.horasTrabalhadas = args;
        }
    }
}