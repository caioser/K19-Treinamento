namespace K19_Treinamento.logica
{
    class PrintPattern1
    {
        public static void Main()
        {
            for (int contador = 1; contador <= 100; contador++)
            {
                int resto = contador % 2;
                if (resto == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine("**");
                }
            }
        }
    }
}
