using System;


namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // getters and setters = add security to fields by encapsulating them
            //                       they are accessors found within properties

            Car car = new Car(100);

            car.Speed = 700;

            Console.WriteLine(car.Speed);
        }
    }

    class Car
    {
        private int speed;

        public Car(int speed)
        {
            Speed = speed; // using the property to set the value
        }

        public int Speed
        {
            get { return speed; } // read
            set                   // write
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}