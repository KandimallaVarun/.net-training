using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        //static void PrintNumbers()
        //{
        //    Console.WriteLine(Thread.CurrentThread.ThreadState);
        //    for(int i = 0; i < 10; i++) 
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        static void Main()
        {
            Console.WriteLine("Main thread started.");

            // Create threads
            Thread t1 = new Thread(PrintNumbers);
            Thread t2 = new Thread(PrintCharacters);

            // Start threads
            t1.Start();
            t2.Start();

            // Wait for threads to finish
            t1.Join();
            t2.Join();

            Console.WriteLine("\nMain thread completed.");
        }

        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"[Number Thread] {i}");
                Thread.Sleep(500); // Simulate work
            }
        }

        static void PrintCharacters()
        {
            for (char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine($"[Character Thread] {c}");
                Thread.Sleep(500); // Simulate work
            }
        }


        //static void Main(string[] args)
        //{


        //    ThreadStart ThreadDelegate = new ThreadStart(PrintNumbers);
        //    Thread ChildThread = new Thread(ThreadDelegate);

        //    Console.WriteLine(ChildThread.ThreadState);
        //    ChildThread.Start();
        //    Console.WriteLine(ChildThread.ThreadState);
        //    Thread.Sleep(2000);
        //    Console.WriteLine(ChildThread.ThreadState);


        //    //Nullable<double> num = null;

        //    //if(num.HasValue) 
        //    //{
        //    //    Console.WriteLine("Value : "+num.Value);
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("Value : NULL");
        //    //}

        //    //double val = num.GetValueOrDefault();

        //    ////Console.WriteLine(val);
        //    //try
        //    //{
        //    //    val = num.Value;
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    Console.WriteLine(ex.Message);
        //    //}

        //}
    }
}
