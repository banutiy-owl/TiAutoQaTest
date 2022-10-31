using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace Testing_cshrp
{
    internal class Program
    {
       

            class A
        {
            static void Main(string[] args)
            {
                //task1
                Console.WriteLine("This is task 1.");
                Console.WriteLine();

                Task1 arrayOfWords;
                string words;
                //
                Console.WriteLine("Please enter words to check if palindrome: ");
                words = Console.ReadLine();
                if (CheckLine(words) == 1)
                {
                    arrayOfWords = new Task1(SplitLine(words));
                    arrayOfWords.CheckWord();
                } 
            }
         
        }


        class B
        {
            static void Main(string[] args)
            {

                //task2
                Console.WriteLine("This is task 2.");
                Console.WriteLine();

                Task2 taskArray;
                string stringLine;

                //

                Console.WriteLine("Please enter the array: ");

                stringLine = Console.ReadLine();
                int[] array = Array.ConvertAll(SplitLine(stringLine), s => int.Parse(s));

                taskArray = new Task2(array);
                taskArray.SwapGivenArray();
            }
        }

        class C
        {
            static void Main(string[] args)
            {

                //task3
                Console.WriteLine("This is task 3.");
                Console.WriteLine();

                Task3 matrix = new Task3();
                matrix.FillWithZerosAndOnes();
            }
        }


        class D
        {
            static void Main(string[] args)
            {

                Console.ReadKey();
                //task4
                Console.WriteLine("This is task 4.");
                Console.WriteLine();
                Thread.Sleep(1000);

                Task4 game = new Task4();
                game.Game();
            }
        }




        public static int CheckLine(string line)
        {
            if (line.Length >= 1)
            {
                return 1;
            }
            else throw new ArgumentException();
            
        }


        public static string[] SplitLine(string line)
        {
            return line.Split(new string[] { " - "," ", ",", ", " }, StringSplitOptions.RemoveEmptyEntries);
        }


    }
}