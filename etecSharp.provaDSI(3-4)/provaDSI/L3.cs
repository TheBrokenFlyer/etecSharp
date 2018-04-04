using System;

namespace prova {
    class Fusca : Carro {
        public static override void locomover() {
            Console.WriteLine("two wheels");
        }

        public static override void abastecer() {
            Console.WriteLine("gasoline\n");
        }
    }

    class PicapeS10 : Carro {
        public static override void locomover() {
            Console.WriteLine("four wheels");
        }

        public static override void abastecer() {
            Console.WriteLine("diesel\n");
        }
    }



    class Cb200 : Motocicleta {
        public static override void locomover() {
            Console.WriteLine("back wheels");
        }

        public static override void abastecer() {
            Console.WriteLine("alcohol\n");
        }
    }



    class Caiaque : Embarcacao {
        public static override void locomover() {
            Console.WriteLine("howing");
        }

        public static override void abastecer() {
            Console.WriteLine("body strenght\n");
        }
    }



    class Esquilo : Aeronave {
        public static override void locomover() {
            Console.WriteLine("rotor");
        }

        public static override void abastecer() {
            Console.WriteLine("diesel\n");
        }
    }

    class Legacy450 : Aeronave {
        public static override void locomover() {
            Console.WriteLine("turbine");
        }

        public static override void abastecer() {
            Console.WriteLine("kerozene\n");
        }


        public static void decolar(int climate) {
            switch (climate) {
                case 0: //sun
                    Console.WriteLine("regular");
                    break;
                case 1: //rain and clowdy
                    Console.WriteLine("with instruments");
                    break;
                case 2: //snow
                    Console.WriteLine("no flight");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }

        public static int decolar(int hour) {
            int altitude=0;

            if (hour < 100) {
                altitude = 5000; //low
            } else if (hour < 1201) {
                altitude = 10000; //high
            } else if (hour < 1801) {
                altitude = 7500; //medium
            } else if (hour < 2359) {
                altitude = 5000; //low
            }

            Console.WriteLine("altitude: " + altitude);
            return altitude;
        }

        public static int decolar(bool areTherePassengers) {
            if (areTherePassengers) {
                Console.WriteLine("make lunch");
                return 1;
            } else {
                Console.WriteLine("fasten the cargo");
                return 0;
            }
        }
    }
}