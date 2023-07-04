namespace K19_Treinamento.orientacao_a_objetos
{
    class TestaValoresPadrao
    {
        public static void Main()
        {
            Conta c = new Conta();

            Console.WriteLine($"{c.numero}\n{c.saldo}\n{c.limite}\n");
        }
    }
}
