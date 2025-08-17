namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation = allows us to embed expressions within string literals
            // syntax: $"string {expression} string"

            String name = "Alice";
            int age = 25;

            Console.WriteLine($"Your name is {name} and you are {age} years old"); // string interpolation
        }
    }
}