using System;

namespace prova {
    class Fusca : Carro {
        public override void locomover() {
            Console.WriteLine("two wheels");
        }

        public override void abastecer() {
            Console.WriteLine("gasoline\n");
        }
    }

    class PicapeS10 : Carro {
        public override void locomover() {
            Console.WriteLine("four wheels");
        }

        public override void abastecer() {
            Console.WriteLine("diesel\n");
        }
    }



    class Cb200 : Motocicleta {
        public override void locomover() {
            Console.WriteLine("back wheels");
        }

        public override void abastecer() {
            Console.WriteLine("alcohol\n");
        }
    }



    class Caiaque : Embarcacao {
        public override void locomover() {
            Console.WriteLine("howing");
        }

        public override void abastecer() {
            Console.WriteLine("body strenght\n");
        }
    }



    class Esquilo : Aeronave {
        public override void locomover() {
            Console.WriteLine("rotor");
        }

        public override void abastecer() {
            Console.WriteLine("diesel\n");
        }
    }

    class Legacy450 : Aeronave {
        public override void locomover() {
            Console.WriteLine("turbine");
        }

        public override void abastecer() {
            Console.WriteLine("kerozene\n");
        }


        public void decolar(int climate) {
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

        public float decolar(float hour) {
            float altitude=0;

            if (hour < 100f) {
                altitude = 5000f; //low
            } else if (hour < 1201f) {
                altitude = 10000f; //high
            } else if (hour < 1801f) {
                altitude = 7500f; //medium
            } else if (hour < 2359f) {
                altitude = 5000f; //low
            }

            Console.WriteLine("altitude: " + altitude);
            return altitude;
        }

        public int decolar(bool areTherePassengers) {
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