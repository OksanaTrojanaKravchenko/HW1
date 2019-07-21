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
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            for (int i = 0; i < array.Length; i++)
            {
                DivisibleByMethod(array[i]);
            }
            Console.ReadLine();

            Console.WriteLine("\nPlease enter upper limit for your array\n");

            string maxValueString = Console.ReadLine();
            int maxValueInt = int.Parse(maxValueString);
            int[] array2 = new int[maxValueInt];
            for (int y = 0; y < array2.Length; y++)
            {
                array2[y] = y + 1;
            }
            for (int y = 0; y < maxValueInt; y++)
            {
                DivisibleByMethod(array2[y]);
            }
        }
        static void DivisibleByMethod(int numberToDoFizzBuzz)
        {
            int zero = 0;
            if (zero == numberToDoFizzBuzz % 15)
                    Console.WriteLine("FizzBuzz");
            else if (zero == numberToDoFizzBuzz % 3 && zero != numberToDoFizzBuzz % 5)
                    Console.WriteLine("Fizz");

            else if (zero != numberToDoFizzBuzz % 3 && zero == numberToDoFizzBuzz % 5)
                    Console.WriteLine("Buzz");

            else
                    Console.Write(numberToDoFizzBuzz + " ");
        }
    }
}
