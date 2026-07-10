using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Week3WebAPI.Filters;
using Week3WebAPI.Models;

namespace Week3WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> employees;

        public EmployeeController()
        {
            employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department
                    {
                        Id = 1,
                        Name = "IT"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "ASP.NET Core" }
                    },
                    DateOfBirth = new DateTime(1998,5,10)
                },

                new Employee
                {
                    Id = 2,
                    Name = "Alice",
                    Salary = 60000,
                    Permanent = false,
                    Department = new Department
                    {
                        Id = 2,
                        Name = "HR"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "Communication" },
                        new Skill { Id = 4, Name = "Recruitment" }
                    },
                    DateOfBirth = new DateTime(1997,8,20)
                }
            };
        }

        // GET api/employee
        [AllowAnonymous]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        // POST api/employee
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }

        // PUT api/employee
        [HttpPut]
        public IActionResult Put([FromBody] Employee employee)
        {
            var emp = employees.FirstOrDefault(e => e.Id == employee.Id);

            if (emp == null)
                return NotFound();

            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.Permanent = employee.Permanent;
            emp.Department = employee.Department;
            emp.Skills = employee.Skills;
            emp.DateOfBirth = employee.DateOfBirth;

            return Ok(emp);
        }
    }
}