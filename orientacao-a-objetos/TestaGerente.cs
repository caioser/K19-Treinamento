namespace K19_Treinamento.orientacao_a_objetos
{
    class TestaGerente
    {
        public static void Main()
        {
            Gerente g = new Gerente();
            g.salario = 1000;

            Console.WriteLine($"Salário: {g.salario}");

            Console.WriteLine("Aumentando o salário em 10%");
            g.AumentaSalario();

            Console.WriteLine($"Salário: {g.salario}");

            Console.WriteLine("Aumentando o salário em 30%");
            g.AumentaSalario(0.3);

            Console.WriteLine($"Salário: {g.salario}");
        }
    }
}
