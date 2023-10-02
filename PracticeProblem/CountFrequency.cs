using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class CountFrequency
    {
        public static void Frequency()
        {
            int[] arr = { 4, 2, 4, 3, 1, 4, 2, 7, 8, 7 };

            Dictionary<int, int> elementFrequency = CountElementFrequency(arr);

            Console.WriteLine("Element Frequency:");
            foreach (var entry in elementFrequency)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} times");
            }
        }
        static Dictionary<int, int> CountElementFrequency(int[] arr)
        {
            Dictionary<int, int> elementFrequency = new Dictionary<int, int>();

            foreach (var element in arr)
            {
                if (elementFrequency.ContainsKey(element))
                    elementFrequency[element]++;
                else
                    elementFrequency[element] = 1;
            }

            return elementFrequency;
        }
    }
}
