
namespace UC3POWEROF2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to power of 2");
            int x = 2;
            Console.WriteLine("please enter the number to raise");
            int y = Convert.ToInt32(Console.ReadLine());
            double z = Math.Pow(x, y);
            Console.WriteLine($"power of number:{z}");
        }
    }
}
