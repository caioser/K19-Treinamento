namespace K19_Treinamento.orientacao_a_objetos
{
    class TestaContaEAgencia
    {
        public static void Main()
        {
            Agencia a = new Agencia(1234);
            Conta c = new Conta(a);

            //a.numero = 178;
            c.saldo = 1000;

            c.agencia = a;

            Console.WriteLine(c.agencia.numero);
            Console.WriteLine(c.saldo);
        }
    }
}
