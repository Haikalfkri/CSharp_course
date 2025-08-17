using System;
using System.Threading;

namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                thread = an excecution path of a program
                         we can use multiple threads to perform,
                         different tasks of our program at the same time.
                         current thread running is "main" thread
                         using System.Threading
            */

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(() => countDown("Timer"));// Using a lambda expression to pass the name parameter
            Thread thread2 = new Thread(countUp);
            thread1.Start();
            thread2.Start();

            //countDown();
            //countUp();

            Console.WriteLine(mainThread.Name + " is complete");
        }
        
        public static void countDown(string name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{name} #1 : {i} seconds");
                Thread.Sleep(1000); // Sleep for 1 second
            }
            Console.WriteLine($"{name} #1 finished!");
        }
        public static void countUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Timer #2 : {i} seconds");
                Thread.Sleep(1000); // Sleep for 1 second
            }
            Console.WriteLine("Timer #2 finished!");
        }
    }
}