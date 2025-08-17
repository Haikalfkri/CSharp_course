using System;


namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                generic = "not specific to a particular data type"
                          add <T> to: classes, methods, fields, etc.
                          allows for code reusability for different data types
            */

            int[] intArrays = { 1, 2, 3, 4, 5 };
            double[] doubleArrays = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            string[] stringArrays = { "one", "two", "three", "four", "five" };

            // Displaying arrays using the generic method
            displayArrays(intArrays);
            displayArrays(doubleArrays);
            displayArrays(stringArrays);
        }

        public static void displayArrays<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}