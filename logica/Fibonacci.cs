namespace K19_Treinamento.logica
{
    class Fibonacci
    {
        public static void Main(int until = 30)
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
}
