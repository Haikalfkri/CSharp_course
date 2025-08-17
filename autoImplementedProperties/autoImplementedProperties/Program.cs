using System;


namespace autoImplementedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto-Implemented properties = shortcut when no additional logic is required in property

            Car car = new Car("Lambo");

            Console.WriteLine(car.Model);
        }
    }

    class Car
    {
        //string model;

        public Car(string model)
        {
            this.Model = model;
        }

        public string Model { get; set; } // Auto-Implemented property

        //public string Model
        //{
        //    get { return model; }
        //    set
        //    {
        //        model = value;
        //    }
        //}
    }
}