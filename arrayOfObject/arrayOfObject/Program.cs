using System;

namespace arrayOfObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] garage1 = new Car[3]; // fixed size array of Car objects

            Car car1 = new Car("Toyota");
            Car car2 = new Car("Honda");
            Car car3 = new Car("Ford");

            garage1[0] = car1;
            garage1[1] = car2;
            garage1[2] = car3;

            Car[] garage2 = {new Car("BMW"), new Car("Audi"), new Car("Mercedes")};

            //Console.WriteLine(garage1[0].model);
            //Console.WriteLine(garage1[1].model);
            //Console.WriteLine(garage1[2].model);

            foreach (Car car in garage1)
            {
                Console.WriteLine(car.model);
            }
            Console.WriteLine("--------------");
            foreach (Car car in garage2)
            {
                Console.WriteLine(car.model);
            }
        }
    }

    class Car
    {
        public string model;

        public Car(string model)
        {
            this.model = model;
        }
    }
}