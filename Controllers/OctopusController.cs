using Microsoft.AspNetCore.Mvc;
using Web_API.Models;

namespace Web_API.Controllers;

[Route("api/Octopus")]
[ApiController]
public class OctopusController : Controller
{
    [HttpGet]
    public async Task<ActionResult<List<Octopus>>> GetOctopuses()
    {
        var octopuses = new List<Octopus>
        {
            new Octopus
            {
                Id = 1,
                Name = "Fred",
                Age = 12
            }
        };
        return Ok(octopuses);
    }
}