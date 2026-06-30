using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name : ");
            //string str = Console.ReadLine();

            //Console.WriteLine("Enter your age : ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your salary : ");
            //double salary = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"Hello {str}! your age is {age} and salary is {salary}");
            //Console.WriteLine("Hello {0}! your age is {1} and salary is {2}", str, age, salary);
            //Console.WriteLine("Hello "+str+"! your age is "+age+" and salary is "+salary);


            int[] arr = new int[5];
            for(int i = 0; i< arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                //while (!int.TryParse(Console.ReadLine(), out arr[i]))
                //{
                //    Console.Write("Invalid input. Enter an integer: ");
                //}
                
            }

            foreach ( int ele in arr )
            {
                Console.WriteLine(ele);
            }
        }
    }
    
    
}
