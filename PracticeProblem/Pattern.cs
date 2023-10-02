using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class Pattern
    {
        public static void Pattern1()
        {
            Console.WriteLine("Enter pattern line.");
            int n=int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j<n-i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern2()
        {
            Console.WriteLine("Enter Pattern line");
            int n1=int.Parse(Console.ReadLine());

            for (int i = 0; i < n1; i++)
            {
                for(int j=0; j< n1; j++)
                {
                    if(i==0 || i==n1-1||j==0||j==n1-1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
