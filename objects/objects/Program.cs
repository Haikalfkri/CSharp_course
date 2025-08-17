using System;

namespace objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class
            // object can have fields and methods (characteristics and behaviors)

            Human human1 = new Human();

            human1.name = "John";
            human1.age = 30;
            
            human1.Speak();
            human1.Walk();
            human1.Eat();
        }
    }

    class Human
    {
        public String name;
        public int age;

        public void Speak()
        {
            Console.WriteLine(name + " is speaking");
        }
        public void Walk()
        {
            Console.WriteLine(name + " is walking");
        }
        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
    }
}