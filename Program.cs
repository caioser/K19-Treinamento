using K19_Treinamento;

Console.WriteLine("Hello, World!");
/*
Método "Main" principal entrypoint e pode ser:
static void Main()
static int Main()
static void Main(string[] args) // agrupa em array de strings cada argumento passado em linha de comando
static int Main(string[] args)
*/

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
    Console.WriteLine("No arguments");
}


//FixExercises.MyName100Times();
//FixExercises.OneTo100();
//FixExercises.Fibonacci();
//Console.WriteLine(Int16.MaxValue);
//Console.Beep();
//Console.SetCursorPosition(0, 0);
//(int Left, int Top) = Console.GetCursorPosition();
//Console.SetCursorPosition(Left + 10, Top);
//Console.WriteLine($"{Left}, {Top}");

GeradorDePadroes.Run();