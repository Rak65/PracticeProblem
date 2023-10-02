using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class FindMaxMin
    {
        public static void MaxMin()
        {
            int[] arr = { 4, 2, 7, 1, 5, 8, 3 };
            if (arr.Length == 0)
            {
                Console.WriteLine("Array is empty.");
                return;
            }

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];

                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine("Maximum element: " + max);
            Console.WriteLine("Minimum element: " + min);
        }
    }
}
