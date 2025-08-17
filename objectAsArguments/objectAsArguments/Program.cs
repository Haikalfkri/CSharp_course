using System;

namespace objectAsArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Red");

            Car car2 = copy(car1);

            //changeColor(car1, "Blue");

            Console.WriteLine(car2.color + " " + car2.model);

            Console.WriteLine();
        }
        public static void changeColor(Car car, string newColor)
        {
            car.color = newColor;
        }
        public static Car copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }

    class Car
    {
        public string model;
        public string color;

        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }
}