using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class ReverseEachWord
    {
        public static void ReverseString()
        {
            Console.WriteLine("Enter the string : ");
            string inputString = Console.ReadLine();
            string reversedString = EachWord(inputString);

            Console.WriteLine("Original String: " + inputString);
            Console.WriteLine("Reversed String: " + reversedString);
        }
        static string EachWord(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }
            return string.Join(" ", words);
        }
    }
}
