namespace K19_Treinamento.orientacao_a_objetos
{
    class TestaAgencia
    {
        public static void Main()
        {
            Agencia a1 = new Agencia(1234);
            a1.numero = 1234;

            Agencia a2 = new Agencia(5678);
            a2.numero = 5678;

            Console.WriteLine(a1.numero);
            Console.WriteLine(a2.numero);
        }
    }
}
