namespace K19_Treinamento.orientacao_a_objetos
{
    class TestaConta
    {
        public static void Main()
        {
            Conta c1 = new Conta(new Agencia(174));
            c1.numero = 1234;
            c1.saldo = 1000;
            c1.limite = 500;

            Conta c2 = new Conta(new Agencia(158));
            c2.numero = 5678;
            c2.saldo = 2000;
            c2.limite = 250;

            Console.WriteLine($"{c1.numero}\n{c1.saldo}\n{c1.limite}\n");
            Console.WriteLine($"{c2.numero}\n{c2.saldo}\n{c2.limite}\n");
        }
    }
}
