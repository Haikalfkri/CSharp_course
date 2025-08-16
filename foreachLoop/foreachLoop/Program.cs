namespace foreachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach loop = a simpler way to iterate through an array, but it's less flexible

            String[] cars = { "BMW", "Tesla", "Ford", "Toyota" };

            // Using foreach to iterate through the array
            foreach( String car in cars )
            {
                Console.WriteLine(car);
            }
        }
    }
}