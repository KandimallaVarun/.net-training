using EFCoreCRUD_Repository.Data;
using EFCoreCRUD_Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCRUD_Repository.Service
{
    public class EmployeeRepoImpl : IEmployeeRepo
    {
        EmployeeDBContext context;

        public EmployeeRepoImpl()
        {
            context = new EmployeeDBContext();
        }
        public bool AddEmployee(Employee employee)
        {
            if(employee != null)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteEmployee(int id)
        {
            if (id > 0)
            {
                var employee = context.Employees.Find(id);
                if (employee != null)
                {
                    context.Employees.Remove(employee);
                    context.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteEmployeeById(int id)
        {
            if(context.Employees.Find(id) != null)
            {
                context.Employees.Remove(context.Employees.Find(id));
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            Employee employee = context.Employees.Find(id);
            return employee;
        }

        public bool UpdateEmployee(int id, Employee employee)
        {
            if(context.Employees.Find(id) != null)
            {
                context.Employees.Update(employee);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
