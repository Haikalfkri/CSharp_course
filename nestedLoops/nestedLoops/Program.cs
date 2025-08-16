namespace nestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // nested loops = loop inside of other loop

            Console.Write("How many rows? ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns? ");
            int cols = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol? ");
            string symbol = Console.ReadLine();


            for ( int i = 1; i <= rows; i++ )
            {
                for ( int j = 1; j <= cols; j++ )
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }
    }
}