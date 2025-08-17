using System;


namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // polymorphism = Greek word that means "many forms"
            //                object can be identified by more than one type

            Bicycle bicycle = new Bicycle();
            Car car = new Car();
            Truck truck = new Truck();

            Vehicle[] vehicles = { bicycle, car, truck };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
        }
    }

    class Vehicle
    {
        public virtual void Go()
        {
            Console.WriteLine("Vehicles is moving");
        }
    }
    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Car is moving");
        }
    }
    class Truck : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("Truck is moving");
        }
    }
}