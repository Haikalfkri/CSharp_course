namespace logicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // logical operators can be used to check if more than 1 condition is true/false
            // && (and) - true if both conditions are true
            // || (or) - true if at least one condition is true

            Console.Write("What's the temperature outside? ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 30)
            {
                Console.WriteLine("Wheater is nice!");
            } else if (temp < 10 || temp > 30)
            {
                Console.WriteLine("Wheater is not nice!");
            }
        }
    }
}