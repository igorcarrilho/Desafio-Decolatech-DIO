using System;

namespace SequenciaS
{
    class Program
    {
        static void Main(string[] args)
        {
          double i, S = 0;

            for (i = 1; i <= 100; i++)
            {
                S += (1 / i);
            }
            Console.WriteLine(Math.Round(S, 2));
        }
    }
}
