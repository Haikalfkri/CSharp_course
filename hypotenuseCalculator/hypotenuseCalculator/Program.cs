using System.Transactions;

namespace hypotenuseCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

             double hypotenuse = Math.Round(Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2)), 2);
            // double hypotenuse = Math.Sqrt((num1 * num1) + (num2 * num2));
            Console.WriteLine($"The hypotenuse is: {hypotenuse}");
        }
    }
}