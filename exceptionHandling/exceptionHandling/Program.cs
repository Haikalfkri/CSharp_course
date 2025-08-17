namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // exception = try some code that is considered "dangerous"

            // try = attempts to execute code that might throw an exception
            // catch = catches and handles exceptions when they occur
            // finally = executes code after try/catch, regardless of whether an exception occurred

            int x;
            int y;
            double result;

            try
            {
                Console.Write("Enter first number: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Only numbers!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divided by zero!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("Excecution completed!");
            }
            
        }
    }
}