using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEx
{
    public struct Student
    {
        public string name;
        public int age;
        public double score;
    }
    internal class Demo
    {
        static void Main(string[] args)
        {
            Student stud;
            stud.name = "Zombie";
            stud.score = 999.998;

            Console.WriteLine($"{stud.name} : {stud.score}");
        }
    }
}
