using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prova {
    class Program {
        static void Main(string[] args) {
            Fusca       F = new Fusca();
            PicapeS10   P = new PicapeS10();
            Cb200       C = new Cb200();
            Caiaque     CH = new Caiaque();
            Esquilo     E = new Esquilo();
            Legacy450   L = new Legacy450();
            
            F.locomover();
            F.abastecer();

            P.locomover();
            P.abastecer();

            C.locomover();
            C.abastecer();

            CH.locomover();
            CH.abastecer();

            E.locomover();
            E.abastecer();

            L.locomover();
            L.abastecer();
            L.decolar(0);
            L.decolar(1);
            L.decolar(2);
            L.decolar(1231232);
            L.decolar(2200f);
            L.decolar(true);
            L.decolar(false);

            Console.ReadKey(true);
        }
    }


    class Veiculo {
        private string marca = null;
        private int ano = 0,
                    pneu = 0;

        public virtual void locomover() { }
        public virtual void abastecer() { }
    }


}
