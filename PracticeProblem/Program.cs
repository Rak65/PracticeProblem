using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while(isRunning)
            {
                Console.WriteLine("Which program you want to run");
                Console.WriteLine("1. Duplicate element in array.");
                Console.WriteLine("2. Unique Elements in array.");
                Console.WriteLine("3. Count frequency of each element.");
                Console.WriteLine("4. Find maximum and minimum element.");
                Console.WriteLine("5. Pattern1");
                Console.WriteLine("6. Pattern2");
                Console.WriteLine("7. Reverse each word of string.");
                Console.WriteLine("8. Sum of digit.");
                Console.WriteLine("9. Exit");
                string choice= Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        DuplicateElement.Element();
                        break;
                    case "2":
                        UniqueElements.PrintUniqueElements();
                        break;
                    case "3":
                        CountFrequency.Frequency();
                        break;
                    case "4":
                        FindMaxMin.MaxMin();
                        break;
                    case "5":
                        Pattern.Pattern1();
                        break;
                    case "6":
                        Pattern.Pattern2();
                        break;
                    case "7":
                        ReverseEachWord.ReverseString();
                        break;
                    case "8":
                        SumOfDigit.CalculateSumOfDigits();
                        break;
                    case "9":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Try again : ----");
                        break;
                }
            }
        }
    }
}
