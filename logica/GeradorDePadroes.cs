namespace K19_Treinamento.logica
{
    class GeradorDePadroes
    {
        public static void Main()
        {
            Console.WriteLine("Gerador de Padrões\n\n");
            int opc = 1;

            Console.WriteLine("Escolha a opção desejada:");
            while (opc != 0)
            {
                Console.WriteLine(
                    "1- Padrão 1\n\n" +
                    "2- Padrão 2\n\n" +
                    "3- Triângulo de Asterísco\n\n" +
                    "4- Vários Triângulos de Asteríscos\n\n" +
                    "5- Sequência de Fibbonaci (n=30)\n\n" +
                    "0- Sair"
                );
                TextReader textReader = Console.In;
                string valorTela = textReader.ReadLine();
                opc = Convert.ToInt32(valorTela);

                if (opc == 1)
                {
                    PrintPattern1.Main();
                }
                else if (opc == 2)
                {
                    PrintPattern2.Main();
                }
                else if (opc == 3)
                {
                    StarTriangle.Main();
                }
                else if (opc == 4)
                {
                    StarTriangleMany.Main();
                }
                else if (opc == 5)
                {
                    Fibonacci.Main();
                }
            }
        }
    }
}
