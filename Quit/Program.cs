//Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.
//Display the unique numbers that the user has entered.

/*while (true)
{
    Console.WriteLine("Enter a number: ");
    var number = Console.ReadLine();
    Console.WriteLine($"You have entered: {number} \nPress Quit to exit.");

    var numbers = new List<string>();
    numbers.Add(number);

    if (number == "Quit")
    {
        Console.WriteLine($"Here are your numbers {numbers}");
    }
}
*/


using System.Collections;

var numbers = new List<int>();

while (true)
{
    Console.WriteLine("Enter a number: Enter Quit to Exit.");
    var input = Console.ReadLine();

    if (input.ToLower() == "quit")
    break;

    numbers.Add(Convert.ToInt32(input));
}
var unique = new List<int>();
foreach (var number in numbers)
{
    if (!unique.Contains(number))
        unique.Add(number);
}
Console.WriteLine("Unique Numbers");
foreach (var number in unique)
    Console.WriteLine(number);
