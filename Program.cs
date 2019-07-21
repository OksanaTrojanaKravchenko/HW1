using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How you prefer to be called?");
            Visitor visitor = new Visitor();
            visitor.ReadNameFromConsole();
            Console.WriteLine("Hello " + visitor.Name + "!");
            Console.ReadLine();

            Ex2FizzBuzz.FizzBuzz();
            Console.ReadLine();

            Console.WriteLine("Guess the number");
            GuessGame.Guess();
        }
    }
    class Visitor
    {
        public string Name;
        public void ReadNameFromConsole() =>
        Name = Console.ReadLine();
    }
}
