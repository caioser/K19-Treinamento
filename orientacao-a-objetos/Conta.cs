namespace K19_Treinamento.orientacao_a_objetos
{
    class Conta
    {
        public int numero;
        public double saldo;
        public double limite = 100;
        public Agencia agencia;

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

        public double ConsultaSaldoDisponivel()
        {
            return this.saldo + this.limite;
        }
    }
}
