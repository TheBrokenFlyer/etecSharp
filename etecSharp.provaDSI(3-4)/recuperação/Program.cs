using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            Assalariado a = new Assalariado();
            Comissionado c = new Comissionado();
            Horista h = new Horista();

            Console.WriteLine("assalariado\n\t{0}\n\t{1}\n\t{2}", a.atraso(30f), a.atraso("aaaaaaa"), a.atraso(true));
            Console.WriteLine("vencimento " + a.vencimento());

            Console.WriteLine(c.vencimento());

            Console.WriteLine(h.vencimento());

            Console.WriteLine("\nAssalariado " + a.setNome("\nname here"));
            Console.WriteLine("\nComissionado " + c.setNome("\nname here2"));
            Console.WriteLine("\nHorista " + h.setNome("\nname here3"));

            Console.ReadKey(true);
        }
    }

    class Empregado {
        private string  Nome=null,
                        Sobrenome=null,
                        CPF=null;

        public string setNome(string nome) {
            return this.Nome = nome;
        }
        public string getNome(string nome) {
            return this.Nome;
        }

        public virtual float vencimento() {
            return 0f;
        }
    }

    class Assalariado : Empregado {
        private float salario = 0;

        public override float vencimento() {
            Console.WriteLine("\nvenc. assalariado");
            return salario;
        }

        public float atraso(float a) {
            return a;
        }
        public string atraso(string a) {
            return a;
        }
        public bool atraso(bool a) {
            return a;
        }
    }

    class Comissionado : Empregado {
        private float   totalVenda = 0f,
                        taxaComissao = 0f;

        public override float vencimento() {
            Console.WriteLine("\nvenc. commissionado");
            return 0f;
        }
    }

    class Horista : Empregado {
        private float   precoHora = 0f,
                        horasTrabalhadas = 0f;

        public override float vencimento() {
            Console.WriteLine("\nvenc. horista");
            return 0f;
        }
    }
}
