using System.Diagnostics.Eventing.Reader;
using System.Text.Json;
using EmployeeManagement.BusinessLayer;
using Microsoft.AspNetCore.Mvc;


namespace EmployeeManagement.Controllers
{

    [ApiController]
    [Route("api/employer")]
    public class EmployerController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployerController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    var empDetails = _employeeService.GetAllEmployees();

        //    if (empDetails == null) { return NotFound(); }

        //    else { return Ok("Success : " + empDetails); } 
        //}
        [HttpGet]
        public IActionResult GetAll()
        {
            var employees = _employeeService.GetAllEmployees();
            var json = JsonSerializer.Serialize(employees);
            Console.WriteLine($"Employees: {json}"); // Debug logging

            return Ok(employees); // Ensures the data is serialized to JSON
        }

    }
}
