using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameterEx
{
    internal class Program
    {
        public static int AddNumber(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static void incr(ref int x)
        {
            x++;
        }

        public static void inoutParameter(in int x, in int y, out int add, out int sub)
        {
            add = x + y;
            sub = x - y;
        }

        static void Main(string[] args)
        {
            ////// Positional arguments cannot follow named arguments. It throws compilation error.
            //Console.WriteLine(AddNumber(firstNumber: 12, 13));

            ////// Named arguments can follow positional arguments.
            //Console.WriteLine(AddNumber(secondNumber:20, firstNumber: 30));

            //int a = 10;
            //incr(ref a);
            //Console.WriteLine(a);

            int x = 10, y = 5, add, sub;
            inoutParameter(in x, in y, out add, out sub);

            Console.WriteLine($"Add : {add}, Sub : {sub}");
        }
    }

}
