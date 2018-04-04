using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prova {
    class Program {
        static void Main(string[] args) {
            Fusca.locomover();
            Fusca.abastecer();

            PicapeS10.locomover();
            PicapeS10.abastecer();

            Cb200.locomover();
            Cb200.abastecer();

            Caiaque.locomover();
            Caiaque.abastecer();

            Esquilo.locomover();
            Esquilo.abastecer();

            Legacy450.locomover();
            Legacy450.abastecer();

            Console.ReadKey(true);
        }
    }


    class Veiculo {
        private string marca = null;
        private int ano = 0,
                    pneu = 0;

        public static virtual void locomover() { }
        public static virtual void abastecer() { }
    }


}
