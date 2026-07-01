using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumEx
{
    public enum days
    {
        Monday=10,
        Tuesday=20,
        Wednesday='W'
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((char)days.Wednesday);
            Console.WriteLine((int)days.Tuesday);
        }
    }
}
