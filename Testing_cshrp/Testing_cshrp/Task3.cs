using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Testing_cshrp
{
    internal class Task3
    {

        int[,] matrix = new int[4, 4]{{ 1, 2, 3, 4},{ 5, 6, 7, 8},{ 9, 10, 11, 12},{ 13, 14, 15, 16}};
        

        public void FillWithZerosAndOnes()
        {
            int[,] result = (int[,])matrix.Clone();
            for (int i = 1; i < result.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    result[i, j] = 0;
                    result[j, i] = 1;
                }
            }


            PrintLnArray(matrix);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            PrintLnArray(result);
        }

        public void PrintLnArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(String.Format("{0}\t", array[i, j]));
                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}
