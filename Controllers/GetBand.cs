namespace Metallix.Controllers;
using Microsoft.AspNetCore.Mvc;
using Metallix;

[ApiController]
[Route("api/[Controller]")]
public class Band : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(DummyData.ExampleDatabase.BandList);
    }
}