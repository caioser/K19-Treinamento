namespace K19_Treinamento.orientacao_a_objetos
{
    class TestaAluno
    {
        public static void Main()
        {
            Aluno a1 = new Aluno();
            a1.nome = "Maria Clara";
            a1.rg = 7854;
            a1.dataDeNascimento = "17/05/2012";

            Aluno a2 = new Aluno();
            a2.nome = "Polyana Oeiras";
            a2.rg = 9856;
            a2.dataDeNascimento = "23/06/2014";

            Console.WriteLine($"{a1.nome}\n{a1.rg}\n{a1.dataDeNascimento}\n");
            Console.WriteLine($"{a2.nome}\n{a2.rg}\n{a2.dataDeNascimento}\n");
        }
    }
}
