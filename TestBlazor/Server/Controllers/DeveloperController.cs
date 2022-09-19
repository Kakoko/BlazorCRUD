using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBlazor.Server.Data.Repositories;
using TestBlazor.Shared.Models;
using TestBlazor.Shared.Models.Dto;

namespace TestBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IDeveloperRepository _developerRepository;

        public UserController(IDeveloperRepository developerRepository)
        {
            _developerRepository = developerRepository;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult<IEnumerable<Developer>> Get()
        {
            return Ok(_developerRepository.GetDeveloperDetails());
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<Developer> Get(Guid id)
        {
            var user = _developerRepository.GetDeveloperData(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult Post([FromBody] DeveloperDto developer)
        {
            var developerToCreate = new Developer()
            {
                Id = Guid.NewGuid(),
                Cellnumber = developer.Cellnumber,
                Email = developer.Email,
                Username = developer.Username
            };
            _developerRepository.AddDeveloper(developerToCreate);
            return Ok("Developer Added");
        }

        // PUT api/<UsersController>/5
        [HttpPut]
        public ActionResult Put([FromBody] Developer developer)
        {
            _developerRepository.UpdateDeveloperDetails(developer);
            return Ok("Developer Updated");
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _developerRepository.DeleteDeveloper(id);
            return Ok("Developer Deleted");
        }
    }


}
