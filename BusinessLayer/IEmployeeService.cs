using EmployeeManagement.Models;

namespace EmployeeManagement.BusinessLayer
{
    public interface IEmployeeService
    {
        public List<Employee> GetAllEmployees();
    }
}
