using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx1
{
    delegate void DelegateEx1();
    internal class Program
    {

        static void display()
        {
            Console.WriteLine("Hello");
        }

        static void display1()
        {
            Console.WriteLine("Hello1");
        }

        static void Main(string[] args)
        {
            DelegateEx1 del = display;
            del();

            del = display1;
            del();
        }
    }
}
