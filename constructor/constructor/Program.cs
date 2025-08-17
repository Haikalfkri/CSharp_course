using System;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // object = A special method in class
            //          same name as class name
            //          can be used to assign arguments to fields when creating an object

            Car car1 = new Car("red", "Mustang", 2023, "Ford");
            Car car2 = new Car("blue", "Civic", 2022, "Honda");

            car1.Drive();
            car2.Drive();
        }
    }

    class Car
    {
        String color;
        String model;
        int year;
        String make;

        public Car(string color, string model, int year, string make)
        {
            this.color = color;
            this.model = model;
            this.year = year;
            this.make = make;
        }

        public void Drive()
        {
            Console.WriteLine($"You drive the {make} {model}");
        }
    }
}