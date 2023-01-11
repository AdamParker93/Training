using System;
using System.Collections.Generic;

namespace ArraysAndListsExcersise
    //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
    //Depending on the number of names provided, display a message based on the above pattern.
    //No input = Nothing Displayed
    //One input = Display Input
    //2 inputs = "Input1" and "Input2"
    //>2 inputs = "Input1", "Input2", "Number of Other Inputs"
{
    public class Program
    {
        static void Main()
        {
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Type a name. Or pres ENTER to Quit.");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;
                names.Add(input);
            }
            if (names.Count == 2)
            {
                Console.WriteLine($"{names[0]}, {names[1]} liked your post");
            }
            else if (names.Count > 2)
            {
                Console.WriteLine($"{names[0]}, {names[1]}, and {names.Count - 2} others liked your post");
            }
            else if (names.Count == 1)
            {
                Console.WriteLine($"{names[0]} liked your post");
            }
            else
                Console.WriteLine();
        }
    }
}