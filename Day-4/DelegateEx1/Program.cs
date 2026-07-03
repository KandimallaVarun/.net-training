using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx1
{
    delegate void DelegateEx1();
    delegate void DelegateEx2(int a, int b);
    delegate void GenDel1<in T1, in T2>(T1 a, T2 b);
    delegate void GenDel2<in T1, in T2, out T3>(T1 a, T2 b);
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
            //DelegateEx1 del = display;
            //del.Invoke();
            //del = display1;
            //del();

            //int x = 10, y = 5;

            //del += display1;

            //DelegateEx2 del2;
            //del2 = delegate(int a, int b)
            //{
            //    Console.WriteLine(a+" : "+b);
            //};

            //del2 += (a, b) => Console.WriteLine(a + " : " + b + "latest");

            //del2(x, y);
            //del.Invoke();

            GenDel1<int, int> del3 = (a, b) => Console.WriteLine(a + " : " + b);
            del3(2,3);

            GenDel2<int, int, int> del4 = (a, b) => Console.WriteLine(a + b);
            //del4(2, 3);

            del4 += (a, b) => Console.WriteLine("Bye! Good Night...");
            del4(2, 3);


            //Action,Func And Prdeicate

            Console.WriteLine("-----Action------------");

            Action<int> action = (x) => Console.WriteLine($"x={x}");
            action(10);

            Action<int, int> add = (x, y) => Console.WriteLine($"Add={x + y}");
            add(10, 22);

            Console.WriteLine("-----Func------------");

            Func<int, int> sq = (x) => x * x;
            Console.WriteLine(sq(5));

            Func<string, string, string> concat = (x, y) => x + y;
            Console.WriteLine(concat("Zombie", "Reddy"));

            Console.WriteLine("-----Predicate------------");

            Predicate<int> iseven = (x) => x % 2 == 0;
            Console.WriteLine(iseven(8));


            //Great question!Action, Func, and Predicate are predefined generic delegates provided by C#. They save you from creating your own delegate types.

            //The main difference is whether they return a value, and if so, what kind of value.

            //Delegate      Takes Parameters?       Returns         Purpose
            //Action        Yes(0–16)               void            Perform an action
            //Func          Yes(0–16)               Any type        Compute and return a value
            //Predicate     Exactly 1               bool            Test a condition

            //give above text in correct format in table format

        }
    }
}
