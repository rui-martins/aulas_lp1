using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMethod
{
    class MyClass
    {
        /// <summary>
        /// Count to 10.
        /// </summary>
        static void CountTo10()
        {
            CountToN(10);
        }
        /// <summary>
        /// Count to number chosen by user.
        /// </summary>
        /// <param name="x"> Number to count to.</param>
        static void CountToN(int x)
        {
            for (int i = 1; i <= x; i++)
                Console.WriteLine(i);
        }
        /// <summary>
        /// Show numbers between n1 and n2.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        static void CountToN(int n1, int n2)
        {
            int numb1, numb2;
            numb1 = Math.Min(n1, n2);
            numb2 = Math.Max(n1, n2);

            for (int i = numb1 + 1; i < numb2; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Main function.
        /// </summary>
        /// <param name="args"> Number of arguments passed by user.</param>
        static void Main(string[] args)
        {
            CountToN(4);
            CountToN(6);
            Console.Write("\n");
            CountToN(4, 10);
        }
    }
}
