using EFCoreCRUD_Repository.Models;
using EFCoreCRUD_Repository.Service;

namespace EFCoreCRUD_Repository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployeeRepo employeeRepo = new EmployeeRepoImpl();

            Console.WriteLine("List of all Employees");

            var employees = employeeRepo.GetAllEmployees();

            foreach (Employee emp in employees)
            {
                Console.WriteLine($"Id: {emp.EmpId}, Name: {emp.Name}, Salary: {emp.Salary}");
            }

            Console.WriteLine("Adding new record");
            Employee newEmployee = new Employee
            {
                Name = "John Doe",
                Position = "Software Engineer",
                Salary = 60000,
                Email = "john@gmail.com"
            };

            if (employeeRepo.AddEmployee(newEmployee))
            {
                Console.WriteLine("Employee added successfully");
            }
            else
            {
                Console.WriteLine("Failed to add employee");
            }

            Console.WriteLine("Updating the record");
            Employee updatedEmployee = employeeRepo.GetEmployeeById(1);

            updatedEmployee.Name = "Jane Smith";
            updatedEmployee.Position = "Senior Software Engineer";

            if (employeeRepo.UpdateEmployee(1, updatedEmployee))
            {
                Console.WriteLine("Employee updated successfully");
            }
            else
            {
                Console.WriteLine("Failed to update employee");
            }

            Console.WriteLine("Deleting the Employee");
            if (employeeRepo.DeleteEmployeeById(1))
            {
                Console.WriteLine("Employee deleted successfully");
            }
            else
            {
                Console.WriteLine("Failed to delete employee");
            }

            Console.ReadKey();
        }
    }
}
