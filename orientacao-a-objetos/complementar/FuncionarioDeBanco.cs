namespace K19_Treinamento.orientacao_a_objetos.complementar
{
    class FuncionarioDeBanco
    {
        public string nome;
        public double salario = 200;

        public void MostrarInformacoes()
        {
            Console.WriteLine(
                $"Nome: {this.nome}\nSalário: {this.salario}"
            );
        }

        public void EditaNome()
        {
            Console.WriteLine("Digite novo nome:");
            this.nome = Console.ReadLine();
        }

        public void EditaSalario()
        {
            Console.WriteLine("Digite novo salário:");
            this.salario = Convert.ToDouble(Console.ReadLine());
        }
    }
}
