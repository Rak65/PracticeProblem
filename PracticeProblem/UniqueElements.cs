using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class UniqueElements
    {
        public static void PrintUniqueElements()
        {
            int[] arr = { 4, 2, 4, 3, 1, 4, 2, 7, 8, 7 };
            Console.WriteLine("Unique elements are : ");
            HashSet<int> uniqueElements = new HashSet<int>();

            foreach (var element in arr)
            {
                if (!uniqueElements.Contains(element))
                {
                    uniqueElements.Add(element);
                    Console.WriteLine(element);
                }
            }
        }
    }
}
