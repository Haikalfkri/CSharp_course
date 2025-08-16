using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variables
            // Initialize and declaration

            int x = 10; // Declaration and initialization
            int y; // Declaration
            y = 20; // Initialization


            int age = 21;
            string name = "John Doe";
            double height = 5.9;
            bool isStudent = true;
            char symbol = 'A';

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("Youe name is " + name + ", you are " + age + " years old");

            Console.ReadKey();
        }
    }
}