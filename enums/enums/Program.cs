using System;


namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // enums = special "class" that contains a set of named integer constants
            //         use enums when you have values that you know will not change
            // enums number defult start at 0, but you can set them to start at any number

            string day = DaysOfWeek.Wednesday.ToString();
            int dayNumber = (int)DaysOfWeek.Wednesday;

            Console.WriteLine(day + " is a day number #" + dayNumber);
            Console.WriteLine(DaysOfWeek.Friday + " is a day number #" + (int)DaysOfWeek.Friday);

            string planetName = planetRadius.Earth.ToString();

            Console.WriteLine(planetName);

            double planetVolume = Volume(planetRadius.Earth);
            Console.WriteLine("The volume of " + planetName + " is " + planetVolume);
        }

        public static double Volume(planetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }
    enum DaysOfWeek
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6,
        Saturday = 7
    }
    enum planetRadius
    {
        Mercury = 2439, // in km
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622
    }
}