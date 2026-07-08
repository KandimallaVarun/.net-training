using Microsoft.EntityFrameworkCore;

namespace EFCore_Relationship
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ApplicationDBContext context = new ApplicationDBContext();

            Console.WriteLine("Eager Loading");
            var Departments = context.Departments.Include(e => e.Employees).ToList();

            foreach (Department dept in Departments)
            {
                Console.WriteLine($"Department : {dept.DeptName}");
                foreach (Employee emp in dept.Employees)
                {
                    Console.WriteLine($"Employee Name : {emp.Name}, Salary : {emp.Salary}");
                }
            }

            Console.WriteLine("\nExplicit Loading");
            var Departments1 = context.Departments.Single(d => d.DeptId == 1);
            var employees = context.Entry(Departments1).Collection(d => d.Employees).Query().Where(e => e.Salary > 20000).ToList();

            foreach (Employee emp in employees)
            {
                Console.WriteLine($"Employee : {emp.Name}");
            }

            Console.WriteLine("\nSql Raw Query");
            var employees1 = context.Employees.FromSqlRaw("Select * from Employees where Salary > 50000").ToList();

            foreach (Employee emp in employees1)
            {
                Console.WriteLine($"Employee : {emp.Name}");
            }

            Console.WriteLine("\nSql Raw Query with Stored Procedure");
            var employees2 = context.Employees.FromSqlRaw("GetAllEmployees").ToList();

            foreach (Employee emp in employees2)
            {
                Console.WriteLine($"Employee : {emp.Name}");
            }

        }
    }
}
