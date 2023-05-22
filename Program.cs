namespace UC1_HEADS_AND_TAILS
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("welcome to heads and tails");
            Console.WriteLine("please enter number of times you want to filp a coin");
            int n = Convert.ToInt32(Console.ReadLine());
            int headcount = 0;
            int tailcount = 0;
            Random random = new Random();
            for (int i = 1; i <= n; i++)
            {
                if (random.NextDouble() > 0.5)
                {
                    headcount++;
                }
                else
                {
                    tailcount++;
                }
            }
            Console.WriteLine("For {0} filps", n);
            Console.WriteLine("percentage of heads: " + ((double)headcount / n) * 100 + "%");
            Console.WriteLine("percentage of tails: " + ((double)tailcount / n) * 100 + "%");
        }
    }
}
        }
    }
}
