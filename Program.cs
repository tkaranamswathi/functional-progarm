namespace UC2_LEAPYEAR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("welcome to leap year");
            int year;
            Console.Write("Input an year : ");
            year = Convert.ToInt32(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Leap Year!");
            }
            else
            {
                Console.WriteLine("Not a Leap Year!");
            }
        }
    }
}
        }
    }
}