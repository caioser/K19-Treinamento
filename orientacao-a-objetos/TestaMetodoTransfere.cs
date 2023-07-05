namespace K19_Treinamento.orientacao_a_objetos
{
    class TestaMetodoTransfere
    {
        public static void Main()
        {
            Agencia a = new Agencia(1234);

            Conta origem = new Conta(a);
            origem.saldo = 1000;

            Conta destino = new Conta(a);
            destino.saldo = 1000;

            origem.Transfere(destino, 500);

            Console.WriteLine($"{origem.saldo}\n{destino.saldo}");
        }
    }
}
