using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCRUDEx
{
    abstract class EmployeeRepo
    {
        public abstract void AddEmployee(Employee emp);
        public abstract void DeleteEmployee(Employee emp);
        public abstract void UpdateEmployee(Employee emp);
        public abstract Employee GetEmployeeById(int id);
        public abstract List<Employee> GetAll();
    }
}
