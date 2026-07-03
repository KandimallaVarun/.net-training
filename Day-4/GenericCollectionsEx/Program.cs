using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Remove(20);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            dict.Remove(2);
            //dict = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            foreach(var item in dict.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in dict.Values)
            {
                Console.WriteLine(item);
            }



            var x = 10;
            Console.WriteLine(x.GetType());// how to check the type of variable in c#? use GetType() method

            dynamic y;
            y = 10L;
            Console.WriteLine(y.GetType()+" : "+y);
            y = "Hello";
            Console.WriteLine(y.GetType());
        }
    }
}
