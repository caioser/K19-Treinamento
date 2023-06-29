//using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace K19_Treinamento
{
    internal class FixExercises
    {
        public static void MyName100Times()
        { 
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Caio Sergio {i}");
            }
        }

        public static void OneTo100()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintPattern1()
        {
            for (int contador = 1; contador <= 100; contador++)
            {
                int resto = contador % 2;
                if (resto == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine("**");
                }
            }
        }

        public static void PrintPattern2()
        {
            for (int contador = 1; contador <= 100; contador++)
            {
                int resto = contador % 4;
                if (resto == 0)
                {
                    Console.WriteLine("PI");
                }
                else
                {
                    Console.WriteLine(contador);
                }
            }
        }

        public static void StarTree(int i=5)
        {
            for (int contador = 1; contador <= i; contador++)
            {
                string star = new('*', contador);
                Console.WriteLine(star);
            }
        }

        public static void StarTreeMany(int i=3)
        {
            for (int contador = 1; contador <= i; contador++)
            {
                StarTree();
            }
        }

        public static void Fibonacci(int until=30)
        {
            var sequence = new List<int>() { 0, 1 };
            
            while (sequence.Count <= until)
            {
                if (sequence.Count < 2 || until < 2) break;

                var last = sequence.Count - 1;

                sequence.Add(
                    sequence[last - 1]
                    + sequence[last]
                );
            }

            for (int index = 1; index < sequence.Count; index++)
            {
                Console.WriteLine($"{index}º \t-> {sequence[index]}");
            }
        }
    }

    class GeradorDePadroes
    {
        public static void Run()
        {
            Console.WriteLine("Gerador de Padrões\n\n");
            int opc = 1;

            Console.WriteLine("Escolha a opção desejada:");
            while (opc != 0)
            {
                Console.WriteLine(
                    "1- Padrão 1\n\n" +
                    "2- Padrão 2\n\n" +
                    "3- Triângulo de Asterísco\n\n" +
                    "4- Vários Triângulos de Asteríscos\n\n" +
                    "5- Sequência de Fibbonaci (n=30)\n\n" +
                    "0- Sair"
                );
                TextReader textReader = Console.In;
                string valorTela = textReader.ReadLine();
                opc = Convert.ToInt32(valorTela);

                if (opc == 1)
                {
                    FixExercises.PrintPattern1();
                }
                else if (opc == 2)
                { 
                    FixExercises.PrintPattern2();
                }
                else if (opc == 3)
                {
                    FixExercises.StarTree();
                }
                else if (opc == 4)
                {
                    FixExercises.StarTreeMany();
                }
                else if (opc == 5)
                {
                    FixExercises.Fibonacci();
                }
            }
        }
    }
}
