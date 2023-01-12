using System.Text;

/* StringBuilder
 * 
 * Defined in System.Text
 * A Mutable string
 * Easy and fast to crfeate and manipulate strings
 * 
 * Not for Searching
 * 
 * IndexOf(), LastIndexOf(), Contains(), StartsWith(),...
 * 
 * String Manipulation Methods
 * 
 * Append(), Insert(), Remove(), Replace(), Clear()
 */

var builder = new StringBuilder("hello world");

builder
    .Append('-', 10)
    .AppendLine()
    .Append("Header")
    .AppendLine()
    .Append('-', 10)
    .Replace('-', '+')
    .Remove(0, 10)
    .Insert(0, new string('-', 10));

Console.WriteLine(builder);

Console.WriteLine($"First char: {builder[0]}");