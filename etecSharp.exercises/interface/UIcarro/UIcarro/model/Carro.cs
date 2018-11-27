using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model {
	public class Carro {
		int id;
		string nome;
		string fabricante;
		int ano;

		public Carro(string nome, string fabricante, int ano) {
			this.nome = nome;
			this.fabricante = fabricante;
			this.ano = ano;
		}
		public Carro(int id, string nome, string fabricante, int ano)
			: this(nome, fabricante, ano) {
			this.id = id;
		}
	}
}
