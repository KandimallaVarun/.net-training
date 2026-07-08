using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadEx
{
    public class Sample
    {
        public void Display()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Item = " + i);
                Thread.Sleep(3000);
            }
        }
        public void Print()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Item = " + i);
                Thread.Sleep(3000);
            }
        }
    }

    internal class Program
    {
        //static void PrintNumbers()
        //{
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Console.WriteLine($"Number: {i}");
        //        Thread.Sleep(1000);
        //    }
        //}

        static void Main(string[] args)
        {
            //Thread.CurrentThread.Name = "MainThread";
            //Console.WriteLine("Current Thread: " + Thread.CurrentThread.Name);

            //Thread thread = new Thread(PrintNumbers);
            //thread.Name = "WorkerThread";
            //thread.Start();

            Sample sample = new Sample();
            Thread t1 = new Thread(new ThreadStart(sample.Display));
            t1.Start();
            t1.Suspend();
            t1.Resume();
            t1 = new Thread(new ThreadStart(sample.Print));
            t1.Start();
            t1.Suspend();
            t1.Resume();
            Console.WriteLine("Hai");


        }
    }
}