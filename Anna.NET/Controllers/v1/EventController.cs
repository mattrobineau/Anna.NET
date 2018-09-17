using Anna.NET.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Anna.NET.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Event(Event ev)
        {
            return Ok();
        }
        }
    }