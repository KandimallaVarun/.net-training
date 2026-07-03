using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 30, 15, 44, 0, 10, 89 };

            var result = from ele in arr
                         where ele % 2 == 0
                         orderby ele
                         select ele;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            var result2 = arr.Where(ele => ele % 2 == 0).OrderByDescending(ele => ele);

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
