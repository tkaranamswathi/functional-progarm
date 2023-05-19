

namespace UC6_REMAINDER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to quotient and remainder");
            Console.WriteLine("please enter first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number");
            int y = Convert.ToInt32(Console.ReadLine());
            int quotient = x / y;
            int remainder = x % y;
            Console.WriteLine("x:{0} y:{1}", x, y);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}