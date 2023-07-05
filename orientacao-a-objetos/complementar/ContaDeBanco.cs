namespace K19_Treinamento.orientacao_a_objetos.complementar
{
    class ContaDeBanco
    {
        public int numero;
        public double limite;
        public double saldo;

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Saca(double valor)
        {
            this.saldo -= valor;
        }

        public void ImprimeExtrato()
        {
            Console.WriteLine($"SALDO: {this.saldo}");
        }
    }
}
