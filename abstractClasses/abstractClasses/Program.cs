using System;


namespace abstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance = 1 or more child classes receiving fields, methods, etc. from a parent class

            Car car1 = new Car();
            Bicycle bicycle1 = new Bicycle();
            //Vehicle vehicle1 = new Vehicle();
        }
    }

    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!!");
        }
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 20;
    }
    class Motorcycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 100;
    }
    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 200;
    }
}