using System;

namespace VaiTerCopa
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            while ((str = Console.ReadLine()) != null)
            {
                int num = int.Parse(str);
                if (num == 0)
                {
                    Console.WriteLine("vai ter copa!");
                }
                else
                {
                    Console.WriteLine("vai ter duas!");
                }
            }
        }
    }
}
