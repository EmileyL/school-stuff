    using System;
    
    namespace TempuratureAndGrades
{
    class Unit1bLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Let's see how your day should go!"); //because I realized I didn't need user input I decided to make a situation
            Console.WriteLine("What is the temperature in Celsius?");
            
            int celsius = 35;

            Console.WriteLine($"The tempurature is {celsius} degrees."); //establishing tempurature to veiwer

            if (celsius >= 30) //if statements are fun
            {
                Console.WriteLine("You should stay inside and drink water.");
            }
            else
            {
                Console.WriteLine("The outside should be okay for you.");
            }

            Console.WriteLine("Now how was your last exam? Please enter the percentage.");

            int gradePercentage = 29;

            if (gradePercentage >= 90)
            {
                Console.WriteLine("You have an A!");
            }
            else if (gradePercentage >= 80)
            {
                Console.WriteLine("You have a B. Maybe you should study more?");
            }
            else if (gradePercentage >= 70)
            {
                Console.WriteLine("You have a C. I know C's get degrees but that doesn't mean you should slack off.");
            }
            else if (gradePercentage >= 60)
            {
                Console.WriteLine("You have a D. You should definetly study more.");
            }
            else
            {
                Console.WriteLine("You have an F. You need to study more.");
            }
        }
    }
}