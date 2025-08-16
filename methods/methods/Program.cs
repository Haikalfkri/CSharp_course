namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // method = perform a section of code, whenever it's called "invoked".
            // benefit = let's us reuse code, making it more organized and easier to maintain.

            String name = "Alice";
            int age = 21;

            // Calling the method to print the birthday song.
            singHappyBirthday(name, age);
        }

        static void singHappyBirthday(String name, int age)
        {
            // This method prints the lyrics of the "Happy Birthday" song.
            Console.WriteLine($"Happy birthday to {name}!");
            Console.WriteLine($"You are {age} years old!");
            Console.WriteLine();
        }
    }
}