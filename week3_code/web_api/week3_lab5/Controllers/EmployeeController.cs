using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using week3_lab5.Models;

namespace week3_lab5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new()
        {
            new Employee { Id = 1, Name = "John", Salary = 50000, Department = "IT" },
            new Employee { Id = 2, Name = "Alice", Salary = 60000, Department = "HR" }
        };

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }
    }
}