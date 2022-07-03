using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, p;

            n = 9;
            p = 3;
            Console.WriteLine("Regem:" + n);
            Console.WriteLine("Regemin Guvveti:" + p);

            double res = Math.Pow(n, p);
            Console.WriteLine("Cavab = {0}", res);
            Console.ReadLine();
        }
    }
}
    