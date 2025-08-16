namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // method overloading = methods with the same name but different parameters

            double total;
            total = multiply(2, 3); // 2 parameters
            total = multiply(2, 3, 4); // 3 parameters
            Console.WriteLine(total);

        }

        static double multiply(double a, double b)
        {
            return a * b;
        }

        static double multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}