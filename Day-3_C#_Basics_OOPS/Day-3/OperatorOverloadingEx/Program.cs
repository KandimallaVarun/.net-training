using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingEx
{

    class Number
    {
        public int value;

        public Number(int value)
        {
            this.value = value;
        }

        public static Number operator +(Number left, Number right)
        {
            int val = left.value - right.value;
            return new Number(val);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Number num1 = new Number(20);
            Number num2 = new Number(5);

            //Number result = num1 + num2;

            Console.WriteLine((num1 + num2).value);

        }
    }
}
