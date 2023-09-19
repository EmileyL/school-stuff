using System;

namespace tempurature
{
    class Program
    {
        static void Main(string[] ars)
        {
            Console.WriteLine("Enter the tempurature in Celsius: ");
            double celsius = Console.ReadLine();
            if (celsius > 30)
            {
                Console.WriteLine("Be safe by drinking water and staying indoors");
            } else
            {
                Console.WriteLine("Have a nice day");
            }

        }
    }
}
