using K19_Treinamento.logica;
using K19_Treinamento.orientacao_a_objetos;

Console.WriteLine("Hello, World!");

// Instruções de nível superior: método "Main" não ímplícito
if (args.Length > 0) // "args" disponível
{
    foreach (var arg in args)
    {
        Console.WriteLine($"Argument={arg}");
    }
}
else
{
    Console.WriteLine(); // "No arguments"
}

//GeradorDePadroes.Main();
//TestaCliente.Main();
//TestaCartaoDeCredito.Main();
//TestaAgencia.Main();
//TestaConta.Main();
//TestaValoresPadrao.Main();
//TestaAluno.Main();
//TestaFuncionario.DeEscola();
//TestaTurma.Main();
//TestaClienteECartao.Main();
//TestaContaEAgencia.Main();
//TestaAlunoETurma.Main();
//TestaMetodosConta.Main();
//TestaFuncionario.DeEmpresa();
//TestaGerente.Main();

TestaMetodoTransfere.Main();