using System;

namespace SequenciaIJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i += 2)
            {
                for (int J = 7; J >= 5; J -= 1) 
                {
                    Console.WriteLine("I=" + i + " J=" + J);
                }
            }
        }
    }
}
