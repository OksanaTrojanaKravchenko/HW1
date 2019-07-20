using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
    class Ex2FizzBuzz
    {
        public static void FizzBuzz()
        {
            int[] array = new int[100];
            Random random1 = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random1.Next(1, 99);
            }
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (j == array[i] % 3 && j == array[i] % 5 && j == array[i] % 15)
                    Console.WriteLine("FizzBuzz");
                else if (j == array[i] % 3 && j != array[i] % 5 && j != array[i] % 15)
                    Console.WriteLine("Fizz");
                else if (j != array[i] % 3 && j == array[i] % 5 && j != array[i] % 15)
                    Console.WriteLine("Buzz");
                else
                    Console.Write(array[i] + " ");
            }
            Console.ReadLine();

            Console.WriteLine("\nPlease enter some number\n");

            string maxValueString = Console.ReadLine();
            int maxValueInt = int.Parse(maxValueString);
            Random random2 = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random2.Next(1, maxValueInt);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (j == array[i] % 3 && j == array[i] % 5 && j == array[i] % 15)
                    Console.WriteLine("FizzBuzz");
                else if (j == array[i] % 3 && j != array[i] % 5 && j != array[i] % 15)
                    Console.WriteLine("Fizz");
                else if (j != array[i] % 3 && j == array[i] % 5 && j != array[i] % 15)
                    Console.WriteLine("Buzz");
                else
                    Console.Write(array[i] + " ");
            }
        }
    }
}
