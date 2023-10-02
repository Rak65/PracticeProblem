using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class DuplicateElement
    {
        public static void Element()
        {
            int[] arr = { 4, 2, 4, 3, 1, 4, 2, 7, 8, 7 };

            Dictionary<int, int> elementCount = CountDuplicates(arr);

            Console.WriteLine("Duplicate elements and their counts:");
            foreach (var entry in elementCount)
            {
                if (entry.Value > 1)
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value} times");
                }
            }

            Console.WriteLine("Total number of duplicate elements: " + TotalDuplicateCount(elementCount));
        }

        static Dictionary<int, int> CountDuplicates(int[] arr)
        {
            Dictionary<int, int> elementCount = new Dictionary<int, int>();

            foreach (var element in arr)
            {
                if (elementCount.ContainsKey(element))
                    elementCount[element]++;
                else
                    elementCount[element] = 1;
            }

            return elementCount;
        }

        static int TotalDuplicateCount(Dictionary<int, int> elementCount)
        {
            int totalCount = 0;

            foreach (var entry in elementCount)
            {
                if (entry.Value > 1)
                    totalCount++;
            }

            return totalCount;
        }
    }
}
