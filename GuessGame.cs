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
            int numberNeedToGuess;
            int inputNumber;
            int minValue = 1;
            int maxValue = 101;
            numberNeedToGuess = random.Next(minValue, maxValue);

            bool IsInBounds (int number)
            {
                if (inputNumber < maxValue && inputNumber > minValue)

                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Your input is not into bounds. Bounds are: from { minValue} to { maxValue}");
                    return false;
                }
            }
            //inputNumber = int.Parse(Console.ReadLine());
            //inputNumber = int.TryParse(Console.ReadLine(), out var inputValue) ? inputValue : 0;
            do
            {
                if ((int.TryParse(Console.ReadLine(), out inputNumber))&& IsInBounds(inputNumber))

                    if (inputNumber > numberNeedToGuess)
                    {
                        maxValue = inputNumber;
                        Console.WriteLine($"Your input is greater. Bounds are: from { minValue} to { maxValue}");
                    }
                    else if (inputNumber < numberNeedToGuess)
                    {
                        minValue = inputNumber;
                        Console.WriteLine($"Your input is less. Bounds are: from { minValue} to { maxValue}");
                    }
                    else if (inputNumber == numberNeedToGuess)
                    {
                        Console.WriteLine("My greetings, you guessed");
                    }
                    else
                        Console.WriteLine("Your input is not a number. Please try again.");
            }
                while (numberNeedToGuess != inputNumber);

        }

    }
}
