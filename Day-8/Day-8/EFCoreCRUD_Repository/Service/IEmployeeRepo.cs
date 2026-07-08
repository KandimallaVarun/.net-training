using EFCoreCRUD_Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCRUD_Repository.Service
{
    public interface IEmployeeRepo
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        bool AddEmployee(Employee employee);
        bool DeleteEmployeeById(int id);
        bool UpdateEmployee(int id, Employee employee);
    }
}
