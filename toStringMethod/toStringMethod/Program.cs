using System;


namespace toStringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString() = converts an object to its string representation so that is suitable for display

            Car car = new Car("Model S", "Tesla", 2020, "Red");

            Console.WriteLine(car);
        }
    }

    class Car
    {
        string model;
        string make;
        int year;
        string color;

        public Car(string model, string make, int year, string color)
        {
            this.model = model;
            this.make = make;
            this.year = year;
            this.color = color;
        }

        public override string ToString()
        {
            string message = $"Car Details:\n" +
                             $"Model: {model}\n" +
                             $"Make: {make}\n" +
                             $"Year: {year}\n" +
                             $"Color: {color}";
            return message;
        }
    }
}