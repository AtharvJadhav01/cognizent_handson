using Microsoft.AspNetCore.Mvc;
using week3_lab4.Models;

namespace week3_lab4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John", Salary = 50000, Department = "IT" },
            new Employee { Id = 2, Name = "Alice", Salary = 60000, Department = "HR" },
            new Employee { Id = 3, Name = "David", Salary = 55000, Department = "Finance" }
        };

        // GET: api/employee
        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        // POST: api/employee
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }

        // PUT: api/employee/1
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);

            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.Department = employee.Department;

            return Ok(existingEmployee);
        }

        // DELETE: api/employee/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return BadRequest("Invalid employee id");
            }

            employees.Remove(employee);

            return Ok(employee);
        }
    }
}