using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW1
{
    class Program
    {
        //Visitor Visitor { get; } = "";
        static void Main(string[] args)
        {
            Console.WriteLine("How you prefer to be called?");
            Visitor visitor = new Visitor();
            visitor.ReadNameFromConsole();
            Console.WriteLine("Hello " + visitor.Name + "!"+"\n\nEnd of the Greeting program" + "\n\nPress any key to start the next one");
            Console.ReadLine();
            //visitor.Name = "";
            Ex2FizzBuzz.FizzBuzz();
            Console.WriteLine("\nEnd of the FizzBuzz program" + "\n\nPress any key to start the next one");

            Console.ReadLine();
            //{
            //    var a = 5;
            //}
            Console.WriteLine("Guess the number");
            GuessGame.Guess();
        }
    }

    class Visitor
    {
        public string Name;

        public void ReadNameFromConsole() 
            => Name = Console.ReadLine();
    }
}

