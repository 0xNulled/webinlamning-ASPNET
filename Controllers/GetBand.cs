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

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var band = DummyData.ExampleDatabase.BandList.FirstOrDefault(b => b.Id == id);

        if (band == null)
        {
            return NotFound();
        }

        return Ok(band);
    }

    [HttpGet("{name}")]
    public IActionResult GetByName(string name)
    {
        var band = DummyData.ExampleDatabase.BandList.Find(b => b.Name == name);

        if (band == null) 
        { 
            return NotFound();
        }

        return Ok(band);
    }

}