namespace K19_Treinamento.orientacao_a_objetos
{
    class TestaMetodosConta
    {
        public static void Main()
        {
            Conta c = new Conta();

            c.Deposita(1000);
            c.ImprimeExtrato();

            c.Saca(100);
            c.ImprimeExtrato();

            double saldoDisponivel = c.ConsultaSaldoDisponivel();
            Console.WriteLine($"SALDO DISPONÍVEL: {saldoDisponivel}");
        }
    }
}
