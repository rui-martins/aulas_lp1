using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_home
{
    class Program
    {
        static void Main(string[] args)
        {
            int xdim, ydim;
            string temp;
            float[,] matrix;
            float minNum = 0f;

            Console.Write("Insert X value: ");
            temp = Console.ReadLine();
            xdim = Convert.ToInt32(temp);

            Console.Write("Insert Y value: ");
            temp = Console.ReadLine();
            ydim = Convert.ToInt32(temp);


            matrix = new float[xdim, ydim];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("Insert Real Number: ");
                    temp = Console.ReadLine();
                    matrix[i, j] = Convert.ToSingle(temp);
                }
            }

            minNum = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (minNum > matrix[i, j])
                    {
                        minNum = matrix[i, j];
                    }
                }
            }


            Console.WriteLine("Min number in array is " + minNum);
        }
    }
}
