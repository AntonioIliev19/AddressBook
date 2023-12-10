using AddressBook.Server.Modals;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;


        public PeopleController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
                var client = _httpClientFactory.CreateClient();
                var response = await client.GetFromJsonAsync<Root>("https://randomuser.me/api/?results=36&exc=login");

                if (response == null)
                {
                    return StatusCode(500, "Error fetching data from API");
                }

                var result = response.Results.Select(r => new
                {
                    FullName = new
                    {
                        r.Name.Title,
                        r.Name.First, 
                        r.Name.Last
                    },
                    Phone = r.Phone,
                    Email = r.Email,
                    Location = new
                    {
                        r.Location.City,
                        r.Location.State,
                        r.Location.Country,
                    },
                    Picture = new
                    {
                        r.Picture.Large,
                        r.Picture.Medium,
                        r.Picture.Thumbnail,
                    }
                }).ToList();

                return Ok(result);
        }
    }
 }
