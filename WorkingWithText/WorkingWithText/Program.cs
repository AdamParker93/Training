//Useful string methods
//Converting a string to a number
//converting a number to a string

//ToLower() "hello world"
//ToUper() "HELLO WORLD"
//Trim()

//Searching : 

//IndoxOf('a')
//LastIndoxOf("hello")

//Substrings :

//Substring(startIndex)
//Substing(startIndex, length)

//Replacing: 

//Replace('a', '!')
//Repalce("mosh", "moshfegh")

//Null cheking

//String.IsNullOrEmpty(str)
//String.IsNullOrWhiteSpace(str)

//Splitting: 

//str.Split(' ')

//Converting Strings to Numbers
/*String s = "1234";
 * int i = int.Parse(s);
 * int j = Convert.ToInt32(s);
*/

/*Converting Numbers to Strings:
 * int i = 1234;
 * string s = i.ToString();  // "1234"
 * string t = i.ToString("C"); //"$1,234,.00:
 * string t = i.ToString("C0"); //$1,234" ("C1") = $1,234.0
*/

//var fullName = "Adam Parker ";
//Console.WriteLine($"Trim: '{fullName.Trim()}'");
//Console.WriteLine($"ToUpper: '{fullName.Trim().ToUpper()}'");

//var index = fullName.IndexOf(' ');
//var firstName = fullName.Substring(0, index);
//var lastName = fullName.Substring(index + 1);
//Console.WriteLine($"FirstName: {firstName}");
//Console.WriteLine($"LastName: {lastName}");

//var names = fullName.Split(' ');
//Console.WriteLine($"FirstName: {names[0]}");
//Console.WriteLine($"LastName: {names[1]}");

//Console.WriteLine(fullName.Replace("Adam", "Adam Jacob"));

//if (String.IsNullOrWhiteSpace(" "))
//    Console.WriteLine("Invalid");

//var str = "25";
//var age = Convert.ToByte(str);
//Console.WriteLine(age);

//float price = 29.95f;
//Console.WriteLine(price.ToString("C0"));


// SUMMARISING TEXT

//var sentence = "This is going to be a really, really, really, really, really long text.";

using WorkingWithText;
{
    var sentence = "This is going to be a really really really really really really really long sentence.";
    var summary = StringUtility.SummerizeText(sentence, 25);
    Console.WriteLine(summary);
}



