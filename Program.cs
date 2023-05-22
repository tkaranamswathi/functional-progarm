
using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace UC5PRIMEFACTORS
{
    internal class Program
    {
        public static void PrimeFactors(int n)
        {
            Console.WriteLine("welcome to factors");
            int n, i;
            Console.WriteLine("Enter the Number:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factors:");
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}


