using System;

namespace UnitOneBLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Degrees in celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            if (celsius > 30)
            {
                Console.WriteLine("Be careful by drinking water and staying indoors.");
            }
            else
            {
                Console.WriteLine("Enjoy your day.");
            }
        }
    }
}