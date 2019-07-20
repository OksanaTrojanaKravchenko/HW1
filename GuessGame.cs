using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
    class GuessGame
    {
        public static void Guess()
        {
            Random random = new Random();
            int numberNeedToGuess = random.Next();
            int inputNumber;
            do
            {
                inputNumber = (int.Parse)(Console.ReadLine());
                if (numberNeedToGuess < inputNumber)
                    Console.WriteLine("Your input is greater. Please try again");
                else if (numberNeedToGuess > inputNumber)
                    Console.WriteLine("Your input is less. Please try again");
                else
                    Console.WriteLine("My greetings, you guessed");
            }
            while (numberNeedToGuess != inputNumber);
        }
    }
}
