using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_cshrp
{
    internal class Task2
    {

        int[] arrayToSwap;


        public Task2(int[] passArray)
        {
            arrayToSwap = new int[passArray.Length];
            arrayToSwap = passArray;
        }

        public void SwapGivenArray()
        {
            Array.Reverse(arrayToSwap);
            Console.WriteLine(string.Join(" ", arrayToSwap));
        }



        
    }
}
