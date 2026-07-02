using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCRUDEx
{
    internal class Program
    {

        static void Main(string[] args)
        {
            EmployeeRepoImpl repo = new EmployeeRepoImpl();
            // perform all CRUD operations
            repo.AddEmployee(new Employee { Id = 1, Name = "John Doe", salary = 50000 });
            repo.DeleteEmployee(new Employee { Id = 1, Name = "John Doe", salary = 50000 });
            repo.UpdateEmployee(new Employee { Id = 1, Name = "John Doe", salary = 60000 });
            List<Employee> employees =  repo.GetAll();
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
            repo.GetEmployeeById(1);
        }
    }
}
