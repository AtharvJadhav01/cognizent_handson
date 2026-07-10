using Microsoft.AspNetCore.Mvc;

namespace Week3WebAPI.Controllers
{
    [ApiController]
    [Route("api/Emp")]
    public class ValuesController : ControllerBase
    {
        private static List<string> values = new List<string>
        {
            "Apple",
            "Banana",
            "Orange"
        };

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(values);
        }

        // POST: api/values?value=Mango
        [HttpPost]
        public IActionResult Post(string value)
        {
            values.Add(value);
            return Ok(values);
        }

        // PUT: api/values/1?value=Grapes
        [HttpPut("{id}")]
        public IActionResult Put(int id, string value)
        {
            if (id < 0 || id >= values.Count)
            {
                return BadRequest("Invalid ID");
            }

            values[id] = value;

            return Ok(values);
        }

        // DELETE: api/values/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= values.Count)
            {
                return BadRequest("Invalid ID");
            }

            values.RemoveAt(id);

            return Ok(values);
        }
    }
}