namespace K19_Treinamento.orientacao_a_objetos.complementar
{
    class TestaContaDeBanco
    {
        public static void Main()
        {
            ContaDeBanco c = new ContaDeBanco();

            Console.WriteLine("Digite o número da conta:");
            c.numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o limite da conta:");
            c.limite = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o saldo da conta:");
            c.saldo = Convert.ToDouble(Console.ReadLine());

            int opc = 1;

            while (opc != 0) 
            {
                Console.WriteLine(
                    "Opções:\n\n" +
                    "1 - Imprimir extrato\n" +
                    "2 - Depositar\n" +
                    "3 - Sacar\n" +
                    "\n0 - Sair\n"
                );

                opc = Convert.ToInt32(Console.ReadLine());

                if ( opc == 1 )
                {
                    c.ImprimeExtrato();
                }
                else if ( opc == 2 )
                {
                    Console.WriteLine("Digite o valor a depositar:");
                    c.Deposita(Convert.ToDouble(Console.ReadLine()));
                }
                else if ( opc == 3)
                {
                    Console.WriteLine("Digite o valor a sacar:");
                    c.Saca(Convert.ToDouble(Console.ReadLine()));
                }
            }
        }
    }
}
