namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // return = returns data back to the place where the method was called
            double x;
            double y;
            double result;

            Console.WriteLine("Enter first number: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = add(x, y);
            Console.WriteLine("the result is " + result);

        }

        static double add(double a, double b)
        {
            double result = a + b;
            return result; // Using return to send the result back to the caller
        }
    }
}