namespace K19_Treinamento.logica
{
    class StarTriangle
    {
        public static void Main(int i = 5)
        {
            for (int contador = 1; contador <= i; contador++)
            {
                string star = new('*', contador);
                Console.WriteLine(star);
            }
        }
    }
}
