namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // conditional operator = used in conditional assignment if a condition is true or false
            // example (condition) ? trueValue : falseValue;

            double temperature = 20;
            String message;

            // Using if statement
            //if (temperature >= 15)
            //{
            //    message = "It's warm outside.";
            //} 
            //else
            //{
            //    message = "It's cold outside.";
            //}

            // Using the conditional operator to determine if it's hot or cold
            message = (temperature >= 15) ? "It's warm outside." : "It's cold outside.";

            Console.WriteLine(message);
        }
    }
}