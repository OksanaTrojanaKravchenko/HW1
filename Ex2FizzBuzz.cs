using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
    class Ex2FizzBuzz
    {
        public static void FizzBuzz()
        {
            Console.WriteLine(OutputArray(CreateArray(100)));
            Console.WriteLine("\nPlease enter upper limit for your array\n");
            string maxValueString = Console.ReadLine();
            int maxValueInt = int.Parse(maxValueString);
            Console.WriteLine(OutputArray(CreateArray(maxValueInt)));
        }

        static int[] CreateArray(int elementsQuantity)
        {
            int[] array = new int[elementsQuantity];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }

        static string OutputArray(int[]array)
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += DivisibleByMethod(array[i]) + "\n";
            }
            return result;
        }

        static string DivisibleByMethod(int numberToDoFizzBuzz)
        {
            //variant 1
            int zero = 0;
            string a = null;
            if (numberToDoFizzBuzz % 3 == zero)
            {
                a += "Fizz";
            }
            if (numberToDoFizzBuzz % 5 == zero)
            {
                a += "Buzz";
            }
            return a ?? numberToDoFizzBuzz.ToString();

            //variant 2
            var b = "";
            //if (numberToDoFizzBuzz % 3 == zero)
            //{
            //    b += "Fizz";
            //}
            //if (numberToDoFizzBuzz % 5 == zero)
            //{
            //    b += "Buzz";
            //}
            //return (b != "") ? b : numberToDoFizzBuzz.ToString();

            //variant 3
            //int zero = 0;
            //if (numberToDoFizzBuzz % 15 == zero)
            //    return "FizzBuzz";
            //else if (numberToDoFizzBuzz % 3 == zero)
            //    return "Fizz";
            //else if (numberToDoFizzBuzz % 5 == zero)
            //    return  "Buzz";
            //else
            //    return numberToDoFizzBuzz.ToString();
        }
    }
}
