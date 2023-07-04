namespace K19_Treinamento.logica
{
    class PrintPattern2
    {
        public static void Main()
        {
            for (int contador = 1; contador <= 100; contador++)
            {
                int resto = contador % 4;
                if (resto == 0)
                {
                    Console.WriteLine("PI");
                }
                else
                {
                    Console.WriteLine(contador);
                }
            }
        }
    }
}
