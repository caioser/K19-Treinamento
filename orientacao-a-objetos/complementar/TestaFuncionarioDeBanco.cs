namespace K19_Treinamento.orientacao_a_objetos.complementar
{
    class TestaFuncionarioDeBanco
    {
        public static void Main()
        {
            FuncionarioDeBanco novo = new FuncionarioDeBanco();

            Console.WriteLine("Digite o nome do Funcionário:");
            novo.nome = Console.ReadLine();

            int opc = 1;

            while (opc != 0)
            {
                Console.WriteLine(
                    "Opções:\n\n" +
                    "1 - Mostrar informações\n" +
                    "2 - Editar nome\n" +
                    "3 - Editar salario\n" +
                    "\n0 - Sair\n"
                );

                opc = Convert.ToInt32(Console.ReadLine());

                if (opc == 1)
                {
                    novo.MostrarInformacoes();
                }
                else if (opc == 2)
                {
                    novo.EditaNome();
                }
                else if (opc == 3)
                {
                    novo.EditaSalario();
                }
            }
        }
        
    }
}
