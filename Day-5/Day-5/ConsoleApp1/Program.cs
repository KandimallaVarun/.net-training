using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string Name { get; set; }
        public int? Marks { get; set; }
        public string Course { get; set; }
    }

    internal class Program
    {

        static void Main(string[] args)
        {

            List<Student> students = new List<Student>()

            {

                new Student() { Name = "John", Marks = 85, Course = "Math" },

                new Student() { Name = "Jane", Marks = 92, Course = "Science" },

                new Student() { Name = "Sam", Marks = null, Course = "Math" },

                new Student() { Name = "Sara", Marks = 78, Course = "English" },

                new Student() { Name = "Tom", Marks = 88, Course = "Science" }

            };

            Console.WriteLine("Query Syntax");

            // Grouping students by course

            var groupedByCourse = from student in students

                                  group student by student.Course into courseGroup

                                  select new

                                  {

                                      Course = courseGroup.Key,

                                      Students = courseGroup.ToList()

                                  };

            // Displaying the grouped results

            foreach (var group in groupedByCourse)

            {

                Console.WriteLine($"Course: {group.Course}");

                foreach (var student in group.Students)

                {

                    Console.WriteLine($" - Name: {student.Name}, Marks: {student.Marks}");

                }

            }

            Console.WriteLine("\nMethod Syntax");

            //Method syntax for grouping students by course

            var groupedByCourseMethod = students.GroupBy(s => s.Course)

                                                 .Select(courseGroup => new

                                                 {

                                                     Course = courseGroup.Key,

                                                     Students = courseGroup.ToList()

                                                 });

            // Displaying the grouped results

            foreach (var group in groupedByCourseMethod)

            {

                Console.WriteLine($"Course: {group.Course}");

                foreach (var student in group.Students)

                {

                    Console.WriteLine($" - Name: {student.Name}, Marks: {student.Marks}");

                }

            }

        }

    }
}