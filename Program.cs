namespace UC9ALPHABETS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("welcome to alphabet");
            Console.Write("Input an Alphabet (A-Z or a-z) : ");
            int ch;
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is not a vowel");
                    break;
            }
            Console.ReadKey();
        }


    }
}