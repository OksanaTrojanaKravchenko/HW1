using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How you prefer to be called?");
            Visitor visitor = new Visitor();
            Console.WriteLine("Hello " + visitor.name + "!");
            Console.ReadLine();

            Ex2FizzBuzz.FizzBuzz();

            Console.WriteLine("Guess the number");
            GuessGame.Guess();
        }
    }
    class Visitor
    {
        public string name = Console.ReadLine();
    }
}
