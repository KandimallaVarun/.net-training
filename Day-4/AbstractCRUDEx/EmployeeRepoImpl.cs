using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCRUDEx
{
    internal class EmployeeRepoImpl : EmployeeRepo
    {
        public override void AddEmployee(Employee emp)
        {
            Console.WriteLine($"Employee added with Id : {emp.Id} Name : {emp.Name}, Salary : {emp.salary}");
        }

        //finish the implementation of the abstract methods in EmployeeRepo class

        public override void DeleteEmployee(Employee emp)
        {
            if (emp != null) 
            {
                Console.WriteLine($"Employee with Id : {emp.Id} deleted successfully");    
            }
            else
            {
                Console.WriteLine("Invalid Employee");
            }
        }

        public override List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>

            {

                new Employee { Id = 1, Name = "John Doe", salary = 50000 },

                new Employee { Id = 2, Name = "Jane Smith", salary = 60000 },

                new Employee { Id = 3, Name = "Bob Johnson", salary = 70000 }

            };

            return employees;

        }

        public override Employee GetEmployeeById(int id)
        {
            return new Employee { Id = 1, Name = "John Doe", salary = 50000 };
        }

        public override void UpdateEmployee(Employee emp)
        {
            Console.WriteLine("Employee Updated");
        }
    }
}
