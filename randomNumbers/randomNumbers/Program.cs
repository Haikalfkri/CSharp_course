namespace randomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int num1 = random.Next(1, 7); // Generates a random number between 1 and 9
            int num2 = random.Next(1, 7); // Generates a random number between 1 and 9
            int num3 = random.Next(1, 7); // Generates a random number between 1 and 9

            double num4 = random.NextDouble(); // Generates a random number between 0.0 and 1.0

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
        }
    }
}