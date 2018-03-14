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
        public void move() {
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

    class Reptile:Animal {
        private string scalesColor = null;

        public string setScalesColor(string args) {
            return this.scalesColor = args;
        }

        public string getScalesColor(string args) {
            return this.scalesColor;
        }
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
}