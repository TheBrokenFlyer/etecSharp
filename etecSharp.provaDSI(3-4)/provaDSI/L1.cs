using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prova {
    class Program {
        static void Main(string[] args) {


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
