using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageEx
{
    class Parent
    {
        public void Display()
        {
            Console.WriteLine("Parent Class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TempChild tempChild = new TempChild();
            tempChild.TempChildDisplay();

            PackageEx2.Child child = new PackageEx2.Child();
            child.Display();
        }
    }
}
