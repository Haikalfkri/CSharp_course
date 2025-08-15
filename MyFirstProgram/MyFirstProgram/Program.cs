using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Hello!"); // This line prints "Hello" without a newline
            Console.WriteLine("Hello!"); // This line prints "Hello!" with a newline

            // This is a comment
            /*
             this is a multi-line comment
             */

            Console.ReadKey(); // Waits for a key press before closing the console window
        }
    }
}