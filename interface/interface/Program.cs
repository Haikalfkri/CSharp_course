using System;


namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface = defines a contract that all the classes inheriting from it must follow
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();


        }
        interface Ipredator
        {
            void Hunt();
        }
        interface Iprey
        {
            void Flee();
        }
        class Rabbit : Iprey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit flees!");
            }
        }

        class Hawk : Ipredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk hunts!");
            }
        }   

        class Fish : Iprey, Ipredator
        {
            public void Hunt()
            {
                Console.WriteLine("The fish hunts for smaller fish!");
            }
            public void Flee()
            {
                Console.WriteLine("The fish swims away!");
            }
        }
    }
}