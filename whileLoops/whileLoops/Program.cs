namespace whileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop = repeats some code while a condition is true

            string username = "";

            while (username == "")
            {
                Console.Write("Enter your username: ");
                username = Console.ReadLine();
            }

            Console.WriteLine($"Your username is {username}");
        }
    }
}