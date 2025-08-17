namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // muldimensional array = array inside an array

            String[] ford = { "Mustang", "F-150", "Explorer" };
            String[] chevy = { "Camaro", "Silverado", "Tahoe" };
            String[] toyota = { "Camry", "Corolla", "RAV4" };

            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
                                     { "Camaro", "Silverado", "Tahoe" },
                                      { "Camry", "Corolla", "RAV4" } };

            parkingLot[0, 2] = "Focus"; // Change the Ford Explorer to a Focus
            parkingLot[1, 0] = "Volt"; // Change the Chevy Camaro to a Volt

            // Console.WriteLine(parkingLot[2, 1]);

            //foreach (String car in parkingLot)
            //{
            //    Console.WriteLine(car);
            //}

            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}