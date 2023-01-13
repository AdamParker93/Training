using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithTextExcerises
{
    internal class Duplicate
    {
        public void Run()
        {
            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a few numbers sperated by a '-':");

                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                var numberStrings = input.Split('-');
                foreach (var str in numberStrings)
                {
                    numbers.Add(int.Parse(str));
                }

                var isDuplicate = false;
                var duplicate = new List<int>();

                foreach (var number in numbers)
                {
                    if (!duplicate.Contains(number))
                    {
                        duplicate.Add(number);
                    }
                    else
                    {
                        isDuplicate = true;
                    }
                }
                var message = isDuplicate ? "Duplicate" : "Not Duplicate";
                Console.WriteLine(message);
            }

        }
    }
}
