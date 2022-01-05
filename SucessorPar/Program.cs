using System;

namespace SucessorPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                // somar 2
                Console.WriteLine(x += 2);
            }
            else
            {
                // somar 1
                Console.WriteLine(x += 1);
            }
        }
    }
}
