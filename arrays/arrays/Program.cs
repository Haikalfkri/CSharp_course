namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // array = a variable that can store multiple values

            String[] cars = new string[3]; // fixed size

            // String[] cars = { "BMW", "Mustang", "Tesla" };

            cars[0] = "Mustang";
            cars[1] = "BMW";
            cars[2] = "Tesla";

            //Console.WriteLine(cars[0]);
            //Console.WriteLine(cars[1]);
            //Console.WriteLine(cars[2]);

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}