namespace K19_Treinamento.orientacao_a_objetos
{
    class TestaFuncionario
    {
        public static void DeEscola()
        {
            Funcionario f1 = new Funcionario();
            f1.nome = "Fulano de Tal";
            f1.cargo = "Professor";
            f1.cargoDosFuncionarios = "Educação";

            Funcionario f2 = new Funcionario();
            f2.nome = "Ciclano Beltrano";
            f2.cargo = "Faxineiro";
            f2.cargoDosFuncionarios = "Manutenção";

            Console.WriteLine($"{f1.nome}\n{f1.cargo}\n{f1.cargoDosFuncionarios}\n");
            Console.WriteLine($"{f2.nome}\n{f2.cargo}\n{f2.cargoDosFuncionarios}\n");
        }

        public static void DeEmpresa()
        {
            Funcionario f1 = new Funcionario();
            f1.nome = "Fulano de Tal";
            f1.salario = 1357;

            f1.ConsultaDados();

            f1.AumentaSalario(300);
            f1.ConsultaDados();
        }
    }
}
