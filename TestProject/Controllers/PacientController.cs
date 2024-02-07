using Microsoft.AspNetCore.Mvc;
using TestProject.Context;
using TestProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientController : ControllerBase
    {
        private readonly DBContext _context;

        public PacientController(DBContext context)
          => (_context) = (context);

        // GET: api/<PacientController>
        [HttpGet]
        public IEnumerable<PacientModel> Get()
        {
            return _context.Pacients.ToList();
        }

        // GET api/<PacientController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PacientController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PacientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PacientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
