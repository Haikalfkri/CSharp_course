namespace ifStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statement = a basic form of decision making

            Console.Write("Enter your score: ");
            int score = Convert.ToInt32(Console.ReadLine());


            if ( score > 100 )
            {
                Console.WriteLine("Invalid Score!!");
            }
            else if ( score >= 90 )
            {
                Console.WriteLine("A Grade");
            }
            else if ( score >= 80 )
            {
                Console.WriteLine("B Grade");
            }
            else if ( score >= 70 )
            {
                Console.WriteLine("C Grade");
            }
            else if ( score >= 60 )
            {
                Console.WriteLine("D Grade");
            }
            else
            {
                Console.WriteLine("Your failed!");
            }
        }
    }
}