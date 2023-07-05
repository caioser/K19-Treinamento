namespace K19_Treinamento.orientacao_a_objetos
{
    class TestaValoresPadrao
    {
        public static void Main()
        {
            Agencia a = new Agencia(1234);
            Conta c = new Conta(a);

            Console.WriteLine($"{c.numero}\n{c.saldo}\n{c.limite}\n");
        }
    }
}
