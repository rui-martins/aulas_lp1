using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_home
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines;

            Console.WriteLine("Choose number of lines");
            lines = Convert.ToInt32(Console.ReadLine());
            int linespace = lines;
            lines *= 2;

            for (int i = 0; i < lines; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("\n");
                    {
                        linespace--;
                        for (int j = 0; j < linespace; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int k = 0; k < i;  k++)
                        Console.Write("*");
                    }
                }
            }
            Console.Write("\n");

        }
    }
}
