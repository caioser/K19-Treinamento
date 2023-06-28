//using System;
//using System.Collections.Generic;
//using System.Linq;
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

        public static void StarTri(int i=5)
        {
            for (int contador = 1; contador <= i; contador++)
            {
                string Star = new('*', contador);
                Console.WriteLine(Star);
            }
        }

        public static void StarTriMany(int i=3)
        {
            for (int contador = 1; contador <= i; contador++)
            {
                StarTri();
            }
        }

        public static void Fibonacci(int until=30)
        {
            // usar Collections ou Arrays, do jeito que está printa mais que 30 numeros dessa sequencia
            int First = 0;
            int Second = 1;
            int Next = First + Second;
            Console.Write($"{First}, {Second}, {Next}, ");
            for (int contador = 0; contador <= until; contador++)
            {
                First = Second;
                Second = Next;
                Next = First + Second;
                Console.Write($"{Next}, ");
            }
        }
    }
}
