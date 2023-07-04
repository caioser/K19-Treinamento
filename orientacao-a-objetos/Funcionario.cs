namespace K19_Treinamento.orientacao_a_objetos
{
    class Funcionario
    {
        public string nome;
        public double salario;
        public string cargo;
        public string cargoDosFuncionarios;

        public void AumentaSalario(double aumento)
        {
            this.salario += aumento;
        }

        public void ConsultaDados()
        {
            Console.WriteLine(
                $"Nome: {this.nome}\n" +
                $"Salario: {this.salario}\n"
                );
        }
    }
}
