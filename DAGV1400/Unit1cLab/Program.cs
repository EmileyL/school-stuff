using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Please insert a positive and whole integer:");
    int input = 5;
    Console.WriteLine($"The number inputted is {input}.");
      for (int i = 1; i <= input; i++) //the +1 always happens after it is executed, which is good
      {
        for (int j = 1; j <= i; j++) //this gets reset everytime the outer loop goes again, making it 1 each time so that it will print "i" the amount of times it is suppossed to
        {
          Console.Write(i);
        }
        Console.WriteLine(); //makes sure the next line will be on a new one.
      }    
    }
  }
}