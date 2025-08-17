using System;

namespace overloadedConstractor
{
    class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructor = technique to create multiple constructors,
            // each with different parameters, to create objects in different ways

            Pizza pizza1 = new Pizza("Thin Crust", "Tomato Sauce", "Pepperoni");
        }
    }

    class Pizza
    {
        String bread;
        String sauce;
        String topping;
        String cheese;

        public Pizza (string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        } 

        public Pizza(string bread, string sauce, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }

        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.topping = topping;
            this.cheese = cheese;
        }
    }
}