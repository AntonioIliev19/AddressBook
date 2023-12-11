using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly PeopleService _peopleService;

        public PeopleController(PeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var people = await _peopleService.GetPeopleAsync();
            return Ok(people);
        }
    }
 }
