using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Testing_cshrp
{
    public class Task1
    {

        public string[] input;
        public Task1(string[] words)
        {
            input = words;
        }

        public void CheckWord()
        {
            foreach (string word in input)
            {
                if( word.SequenceEqual(word.Reverse()))
                {
                    System.Console.WriteLine($"{word} - palindrome");
                }
                else
                {
                    System.Console.WriteLine($"{word} - not palindrome");
                }
            }
        }

    }
}
