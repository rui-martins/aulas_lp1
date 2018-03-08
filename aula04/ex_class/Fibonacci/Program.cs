using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Fibonacci(int n)
        {
            int fib;

            if (n == 1 || n == 2)
            {
                fib = 1;
            }
            else
            {
                fib = Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            return fib;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n;
            int fib;

            Console.WriteLine("Insert Input:");
            n = Convert.ToInt32(Console.ReadLine());
            fib = Fibonacci(n);
            Console.WriteLine(fib);
        }
    }
}
