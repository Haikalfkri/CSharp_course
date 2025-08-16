namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // params keyword = a method parameter that takes variable number of arguments

            double total = checkOut(19.99, 5.49, 3.99, 12.50, 7.25);
            Console.WriteLine(total);
        }

        static double checkOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }
    }
}