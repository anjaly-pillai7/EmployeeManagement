using EmployeeManagement.Models;

namespace EmployeeManagement.DataLayer
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetAllEmployees();
    }
}
