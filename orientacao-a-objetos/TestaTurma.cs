namespace K19_Treinamento.orientacao_a_objetos
{
    class TestaTurma
    {
        public static void Main()
        {
            Turma t1 = new Turma();
            t1.periodo = "manhã";
            t1.serie = 1;
            t1.sigla = "M1";
            t1.tipoEnsino = "Fundamental 1";

            Turma t2 = new Turma();
            t2.periodo = "tarde";
            t2.serie = 6;
            t2.sigla = "T6";
            t2.tipoEnsino = "Fundamental 2";

            Console.WriteLine($"{t1.periodo}\n{t1.serie}\n{t1.sigla}\n{t1.tipoEnsino}\n");
            Console.WriteLine($"{t2.periodo}\n{t2.serie}\n{t2.sigla}\n{t2.tipoEnsino}\n");
        }
    }
}
