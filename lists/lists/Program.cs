using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that represents a list of objects that can be accessed by index
            //        similiar to arrays, but can grow and shrink dynamically
            //        using Sysmtem.Collections.Generic;

            List<string> foods = new List<string>();

            foods.Add("hamburger");
            foods.Add("pizza");
            foods.Add("hot dog");
            foods.Add("taco");

            // foods.Remove("hot dog");
            // foods.Insert(2, "sushi");
            // Console.WriteLine(foods.Count);
            // Console.WriteLine(foods.IndexOf("pizza")); 
            // Console.WriteLine(foods.Contains("taco"));
            // foods.Sort();
            // foods.Reverse();
            // foods.Clear();
            string[] foodArray = foods.ToArray();

            //Console.WriteLine(foods[0]);

            foreach (string food in foodArray)
            {
                Console.WriteLine(food);
            }
        }
    }
}