using System;

namespace userInput
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your first name: ");
            String firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            String lastName = Console.ReadLine();

            Console.Write("Enyer your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is " + firstName + " " + lastName + " and you are " + 
                                age + " years old"); 

        }
    }
}