using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithTextExcerises
{
    internal class PickingCharacters
    {
        public void Run()
        {
            //5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.

            Console.WriteLine("Enter and English word: ");
            var input = Console.ReadLine().ToLower();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var vowelSet = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
            var vowelCount = 0;

            foreach (var character in input)
            {
                if (vowelSet.Contains(character))
                    vowelCount++;
            }

            var output = "";

            Console.WriteLine(output += vowelCount);
        }
    }
}

