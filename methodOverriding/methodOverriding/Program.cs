using System;

namespace methodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            // method overriding = provides a new version of a method inherited from a parent class
            //                     inherited method must be: abstract, virtual, or already overridden
            //                     Used with ToString() method, polymorphism

            Cat cat = new Cat();
            Dog dog = new Dog();

            cat.Speak();
            dog.Speak();
        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animals is speaking");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat goes *meow*");
        }
    }
    class Dog : Animal
    {

    }
}