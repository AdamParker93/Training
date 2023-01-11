using System;
using System.Globalization;

namespace ArraysandLists;

/*single Dimension arrays
 * array represents a fixed # of variables of sinbler type
 * Single dimension 
 * var numbers = new int[5]
 * var numbers = new int[1, 2, 3, 4, 5]
 * Multi Dimension arrays
 * Rectangle = ex: 3x5
 *  var matrix = new int[3,5];
 *  var matrix = new int[3,5]
 *  {
 *      {1, 2, 3, 4, 5 },
 *      {6, 7, 8, 9, 10 },
 *      {11, 12, 13, 14, 15 },
 *  };
 *  
 *  var element = matrix[0,0];
 *  
 *  var colors = new int[3, 5, 4]
 * 
 * Jagged = 0,1,2,3
 *          0,1,2,3,4
 *          0,1,2
 * var array = new int[3][];
 * 
 * array[0]; 
 */

    class program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };
            //lenth
            Console.WriteLine("Length: " + numbers.Length);
        // IndexOf()
        
         var index = Array.IndexOf(numbers, 9);
        Console.WriteLine("Index of 9: " + index);

        // Clear()
        Array.Clear(numbers, 0, 2);

        Console.WriteLine("Effect of Clear() ");
        foreach (var n in numbers)
            Console.WriteLine(n);
        
        // Copy()
        int[] another = new int[3];
        Array.Copy(numbers, another, 3);

        Console.WriteLine("Effect of Copy()");
        foreach (var n in another)
            Console.WriteLine(n);

        // Sort()
        Array.Sort(numbers);

        Console.WriteLine("Effects of Sort()");
        foreach (var n in numbers)
            Console.WriteLine(n);

        // Reverse()
        Array.Reverse(numbers);

        Console.WriteLine("Effects of Reverse()");
        foreach (var n in numbers)
            Console.WriteLine(n);

        // List: Dynamic size
        // Array ; Fixed size

        var numbers = new List<int>() {1, 2, 3, 4 };
        numbers.add(1);


            }
    }