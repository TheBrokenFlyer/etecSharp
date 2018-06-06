namespace prova {
    class Carro         : Veiculo {
        private string corCarro = null;
    }

    class Motocicleta   : Veiculo {
        private string corMotocicleta = null;
    }

    class Embarcacao    : Veiculo {
        private string corCasco = null;

        public void ancorar() { }
    }

    class Aeronave      : Veiculo {
        private string corFuselagem = null;

        public void arremeter() {}
    }
}