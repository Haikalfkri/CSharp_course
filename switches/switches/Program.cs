namespace switches
{
    class Progam
    {
        static void Main(string[] args)
        {

            // switch = an efficient alternative to many else if statements

            Console.Write("What day is today? ");
            String day = Console.ReadLine();

            switch (day.ToLower())
            {
                case "monday":
                    Console.WriteLine("It's monday");
                    break;
                case "tuesday":
                    Console.WriteLine("It's tuesday");
                    break;
                case "wednesday":
                    Console.WriteLine("It's wednesday");
                    break;
                case "thursday":
                    Console.WriteLine("It's thursday");
                    break;
                case "friday":
                    Console.WriteLine("It's friday");
                    break;
                case "saturday":
                    Console.WriteLine("It's saturday");
                    break;
                case "sunday":
                    Console.WriteLine("It's sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Day");
                    break;
            }

        }
    }
}