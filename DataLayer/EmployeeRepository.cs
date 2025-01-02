using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace EmployeeManagement.DataLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {
        
        public readonly List<Employee> _employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "John Doe", Position = "Software Developer", Salary = 60000 },
            new Employee { Id = 2, Name = "Jane Smith", Position = "Project Manager", Salary = 75000 },
            new Employee { Id = 3, Name = "Emily Davis", Position = "QA Analyst", Salary = 50000 }
        };
        public List<Employee> GetAllEmployees()
        {

            return  _employees;
        }
    }
}
