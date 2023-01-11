using System;

namespace Excersises
{
    public class Conditionals
    {
        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        class program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Enter Image Width : ");
                    var width = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Now enter Height : ");
                    var height = Convert.ToInt32(Console.ReadLine());

                if (width > height)
                    Console.WriteLine("Lanscape");
                else
                    Console.WriteLine("Portrait");
                
                }
            }
        }
}