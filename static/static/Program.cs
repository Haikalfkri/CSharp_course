using System;

namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // static = modifier to declare a static member, which belongs to the class
            //          itself rather than to instances of the class

            Car car1 = new Car("Toyota");
            Car car2 = new Car("Honda");

            Console.WriteLine(Car.numberOfCars);
        }
    }

    class Car
    {
        String model;
        public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }
    }
}