using K19_Treinamento.logica;

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

GeradorDePadroes.Main();