using EmployeeManagement.DataLayer;
using EmployeeManagement.Models;

namespace EmployeeManagement.BusinessLayer
{
    public class EmployeeService :IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public  EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository ;
        }



        public List<Employee> GetAllEmployees()
        {
            return  _repository.GetAllEmployees();
        }
    }
}
