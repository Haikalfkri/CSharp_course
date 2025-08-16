using System;


namespace typeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type Casting = Converting a variable from one type to another

            double a = 9.78;
            int b = Convert.ToInt32(a); // Implicit conversion from double to int

            int c = 10;
            double d = Convert.ToDouble(c);

            int e = 5;
            string f = e.ToString();

            string g = "@";
            char h = Convert.ToChar(g);

            string i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(j.GetType());

        }
    }
}