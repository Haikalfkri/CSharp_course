using System;


namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance = 1 or more child classes receiving fields, methods, etc. from a parent class

            Car car1 = new Car();
            car1.go();
            Console.WriteLine("Car has " + car1.wheels + " wheels.");

            Bicycle bicycle1 = new Bicycle();
            bicycle1.go();
            Console.WriteLine("Bicycle has " + bicycle1.wheels + " wheels.");

        }
    }

    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!!");
        }
    }
    class Bicycle : Vehicle // bicycle inherits from Vehicle
    {
        public int wheels = 2;
    }
    class Motorcycle : Vehicle // motorcycle inherits from Vehicle
    {
        public int wheels = 2;
    }
    class Car : Vehicle // car inherits from Vehicle
    {
        public int wheels = 4;
    }
}