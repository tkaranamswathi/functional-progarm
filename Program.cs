namespace UC4HARMONIC
{
    internal class Program
    {
        static double nthHarmonic(int N)
        {
            double[] harmonic = new double[N + 1];
            harmonic[1] = 1.0;
            for (int i = 2; i <= N; i++)
            {
                harmonic[i] = harmonic[i - 1] + 1.0 / i;
            }

            return harmonic[N];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number");
           int N =Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine(nthHarmonic(N));
        }
    }
}