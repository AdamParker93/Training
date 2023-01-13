public class PascalCase
{
    //4 - Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents".Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

    //Take input, handle null, gather "", create list of string(input), ? convert to PascalCase?, print
    public void Run()
    {

        Console.WriteLine("Enter a few words serparted by a space: ");

        var input = (Console.ReadLine());
        //handles null
        if (String.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Try Again!");
            return;
        }

        //declare output of later

        var output = "";

        //pull words from input
        //create object "pascalCase" to grab index[0] from "word" to Upper + index remainder to Lower
        //combine "output" with "pascalCase" for correct Console.WriteLine.

        foreach (var word in input.Split(' '))
        {
            var pascalCase = char.ToUpper(word[0]) + word.Substring(1).ToLower();
            output += pascalCase;
        }

        Console.WriteLine($"output");
    }
}


