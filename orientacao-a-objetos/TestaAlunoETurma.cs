namespace K19_Treinamento.orientacao_a_objetos
{
    class TestaAlunoETurma
    {
        public static void Main()
        {
            Turma t = new Turma();
            Aluno a = new Aluno();

            t.sigla = "M3";
            a.nome = "Polyana Oeiras";

            a.turma = t;

            Console.WriteLine(a.nome);
            Console.WriteLine(a.turma.sigla);
        }
    }
}
