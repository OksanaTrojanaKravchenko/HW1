using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    class Program2
    {
        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
            string inputString = Console.ReadLine();
            Console.WriteLine(inputString);
            string[] splitedInputString = inputString.Split(new[] { "--" }, StringSplitOptions.None);
            //foreach (string s in splitedInputString)
            //{
            //    Console.WriteLine(s);
            //}
            for (int i = 0; i < splitedInputString.Length; i++)
            {
                if (splitedInputString[i].Contains("number"))
                {
                    char[] charsToTrimNumber = { '-', 'n', 'u', 'm', 'b', 'e', 'r', '=', ' ' };
                    int trimmedNumber;
                    if (int.TryParse(splitedInputString[i].Trim(charsToTrimNumber), out trimmedNumber))
                    {
                        Console.WriteLine($"number: { trimmedNumber}");
                    }
                    else
                    {
                        Console.WriteLine("number is a mandatory parameter");
                    }
                }
                else if (splitedInputString[i].Contains("string="))
                {
                    string[] newSplitedString = splitedInputString[i].Split('=');
                    char[] charsToTrimString = { '"', ' ' };
                    if (newSplitedString.Length > 0)
                    {
                        string trimmedString = newSplitedString[1].Trim(charsToTrimString);
                        Console.WriteLine($"string: { trimmedString}");
                    }
                    else
                    {
                        Console.WriteLine("string: was skipped");
                    }
                }
            }
            Console.ReadLine();
        }
 
    }
}
