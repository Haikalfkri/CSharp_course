namespace mathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.4;
            double y = 5;

            double a = Math.Pow(x, 2); // x^2
            double b = Math.Sqrt(x); // √x
            double c = Math.Abs(x);
            double d = Math.Round(x); // Round to nearest integer
            double e = Math.Ceiling(x); // Round up to nearest integer
            double f = Math.Floor(x); // Round down to nearest integer
            double g = Math.Max(x, y); // Maximum of x and y
            double h = Math.Min(x, y); // Minimum of x and y

            Console.WriteLine(d);
        }
    }
}