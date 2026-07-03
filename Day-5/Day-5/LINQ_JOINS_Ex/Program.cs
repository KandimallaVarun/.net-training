using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace LINQ_JOINS_Ex

{

    class Departments

    {

        public int? DeptId { get; set; }

        public string DeptName { get; set; }

    }

    class Employees

    {

        public int? Id { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }

        public int? DepartmentId { get; set; }

    }

    internal class Program

    {

        static void Main(string[] args)

        {

            //List<Departments> depts = new List<Departments>()

            //{

            //    new Departments{ DeptId=1,DeptName="IT"},

            //    new Departments{ DeptId=2,DeptName="HR"},

            //    new Departments{ DeptId=3,DeptName="Sales"},

            //    new Departments{ DeptId=4,DeptName="Finance"},

            //};

            //List<Employees> emps = new List<Employees>()

            //{

            //    new Employees(){Id=101,Name="Anil",Salary=10000,DepartmentId=1 },

            //    new Employees(){Id=103,Name="Bala",Salary=20000,DepartmentId=1 },

            //    new Employees(){Id=104,Name="Ramu",Salary=35000,DepartmentId=2 },

            //    new Employees(){Id=102,Name="Kumar",Salary=15000,DepartmentId=null },

            //    new Employees(){Id=105,Name="Madhu",Salary=25000,DepartmentId=3 },

            //};

            //var empsdata = from e in emps
            //               join d in depts
            //               on e.DepartmentId equals d.DeptId   //select e.name, e.salary, d.deptname from emps e join depts d on e.DepartmentId = d.DeptId
            //               orderby d.DeptName

            //               //where d.DeptName == "IT"
            //               select new
            //               {
            //                   empname = e.Name,
            //                   empsalary = e.Salary,
            //                   empdept = d.DeptName
            //               };

            //foreach (var emp in empsdata)
            //{
            //    Console.WriteLine($"Name:{emp.empname} Salary:{emp.empsalary} Department:{emp.empdept}");
            //}

            //var empsdata2 = emps.Join(depts, e => e.DepartmentId, d => d.DeptId, (e, d) => new
            //{
            //    empname = e.Name,
            //    empsalary = e.Salary,
            //    empdept = d.DeptName
            //}).OrderBy(e => e.empdept);

            //foreach (var emp in empsdata2)
            //{
            //    Console.WriteLine($"Name:{emp.empname} Salary:{emp.empsalary} Department:{emp.empdept}");
            //}


            int[] score = { 4, -16 };

            Console.WriteLine(score.Sum());

            Console.WriteLine(score.Sum((x) => Math.Sqrt(x)));

            Console.WriteLine(score.Max());

            Console.WriteLine(score.Max((e) => e * 2));


        }

    }

}
